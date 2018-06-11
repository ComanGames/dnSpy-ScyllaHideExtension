using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media;
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

			MyLogger.Instance.WriteLine(TextColor.Red, $"Dbg Manager is OnStart");
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
				

			if (dbgManager.Processes.Length>0) {
				for (int i = 0; i < dbgManager.Processes.Length; i++)
				{
					ulong pid = dbgManager.Processes[i].Id;
					StartScyllaDide(pid,dbgManager,message);
					MyLogger.Instance.WriteLine(TextColor.Red, $"PointerSize = {dbgManager.Processes[i].PointerSize}");

				}
			}
		}

		private static void StartScyllaDide(ulong proccessId, DbgManager dbgManager, DbgMessageEventArgs mesage)
		{

			switch (mesage.Kind)
			{


				case DbgMessageKind.ProcessCreated:
						string currentDirectory = System.Environment.CurrentDirectory;
						ScyllaHideInit(currentDirectory);
						MyLogger.Instance.WriteLine(TextColor.Red, $"InitScyllaHide");

						DbgMessageProcessCreatedEventArgs processCreated = (DbgMessageProcessCreatedEventArgs) mesage;

						ScyllaHideDebugLoop(1, (int) proccessId, true, false);
						ScyllaHideDebugLoop(3, (int)proccessId);


					MyLogger.Instance.WriteLine(TextColor.Red, $"PointerSize = {processCreated.Process.PointerSize}");
					break;


				case DbgMessageKind.ModuleLoaded:

					DbgMessageModuleLoadedEventArgs moduleLoaded = (DbgMessageModuleLoadedEventArgs) mesage;
					string filename = moduleLoaded.Module.Filename;
					if (filename.Contains(".dll"))
					{
						bool IsNtDLL = filename.Contains("ntdll.dll");
						ScyllaHideDebugLoop(2, (int) proccessId, false, IsNtDLL);

						MyLogger.Instance.WriteLine(TextColor.Red, $"Scylla Hide dll loaded	");
					}

					break;
				case DbgMessageKind.BoundBreakpoint:

						ScyllaHideDebugLoop(3, (int) proccessId);
						MyLogger.Instance.WriteLine(TextColor.Red, $"Scylla Hide Breakpoint");
				break;

				default:
						ScyllaHideDebugLoop(0, (int) proccessId);
						MyLogger.Instance.WriteLine(TextColor.Red, $"Scylla Hide otherDebug message");
				break;

			}

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


		[DllImport("ScyllaHideDnSpyPluginx64.dll", EntryPoint = "ScyllaHideInit", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ScyllaHideInit([Out, MarshalAsAttribute(UnmanagedType.LPWStr)] string directory);

		[DllImport("ScyllaHideDnSpyPluginx64.dll", CallingConvention = CallingConvention.Cdecl)]

		private static extern void ScyllaHideReset();

		[DllImport("ScyllaHideDnSpyPluginx64.dll", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ScyllaHideDebugLoop(int DebugEvent, int ProcessID, bool lpStartAddressIsNull = false, bool lpBaseOfNtDll = false);

		private const string DllFilePath = @"ScyllaHideGenericPluginx64.dll";
	}
} 