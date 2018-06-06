using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using dnSpy.Contracts.App;
using dnSpy.Contracts.Debugger;
using dnSpy.Contracts.Text;
using Example2.Extension;

namespace dnSpy.ScyllaHide {


	[Export(typeof(IDbgManagerStartListener))]
	sealed class DebugStart : IDbgManagerStartListener
	{
		public static SynchronizationContext main;
		public static DbgManager dbg;
		public static DebugStart Instance;

		[Import]
		public ScyllaHideSettings ProgrammSettings { get; set; }

		public void OnStart(DbgManager dbgManager) {

            dbg = dbgManager;
		    main = SynchronizationContext.Current;
			Instance = this;

//			dbgManager.IsRunningChanged += (sender, message) => { MessageFromDbg(dbgManager); };
			dbgManager.Message += (sender, args) => { MessageFromDbg(dbgManager,args); };
		}

		private void MyCustomMethod(DbgManager dbgManager, DbgCollectionChangedEventArgs<DbgProcess> args)
		{
			throw new System.NotImplementedException();
		}

		private static int order;
		private static void MessageFromDbg(DbgManager dbgManager, DbgMessageEventArgs message)
		{

			MyLogger.Instance.WriteLine($"We have message type {message.Kind.ToString()}");
			if (message.Kind == DbgMessageKind.ModuleLoaded)
			{
				DbgMessageModuleLoadedEventArgs moduleLoaded = (DbgMessageModuleLoadedEventArgs) message;
				MyLogger.Instance.WriteLine($"ModuleLoaded: {moduleLoaded.Module.Filename}");


			}
			if (!Instance.ProgrammSettings.IsEnabledOption)
				return;
				
			if (message.Kind==DbgMessageKind.ProcessCreated&&dbgManager.Processes.Length>0) {
				for (int i = 0; i < dbgManager.Processes.Length; i++)
				{
					ulong pid = dbgManager.Processes[i].Id;
					StartScyllaDide(pid);
				}
			}
		}

		private static void StartScyllaDide(ulong proccessId) {
			string currentDirectory = System.Environment.CurrentDirectory;
            string scyllaProg = currentDirectory+ @"\InjectorCLIx64.exe";
			string dll = currentDirectory+ @"\HookLibraryx64.dll";	

//            main.Post(o => { MsgBox.Instance.Show(currentDirectory); } ,null);

//			injectDll((int) proccessId, dll);
			InjectUsingProgram(proccessId, scyllaProg, dll);
		}

		private static void InjectUsingProgram(ulong proccessId, string scyllaProg, string dll)
		{
			ProcessStartInfo startInfo = new ProcessStartInfo();
			startInfo.FileName = scyllaProg;
			startInfo.Arguments = $"pid:{proccessId} {dll}";
			startInfo.CreateNoWindow = true;

			Thread newThrad = new Thread(() => { Process.Start(startInfo); });
			newThrad.Start();
		}

		[DllImport("ScyllaHideGenericPluginx64.dll")]
		private static extern bool injectDll(int processId,string dllPath);

	}
} 