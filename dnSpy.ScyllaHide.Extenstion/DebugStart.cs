using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Threading;
using dnSpy.Contracts.App;
using dnSpy.Contracts.Debugger;

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

//			dbgManager.IsRunningChanged += (sender, message) => { ShowCountOfProcesses(dbgManager); };
			dbgManager.Message += (sender, args) => { ShowCountOfProcesses(dbgManager,args); };
		}

		private static int order;
		private static void ShowCountOfProcesses(DbgManager dbgManager, DbgMessageEventArgs message)
		{

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

			ProcessStartInfo startInfo = new ProcessStartInfo();
			startInfo.FileName = scyllaProg;
			startInfo.Arguments = $"pid:{proccessId} {dll}";
			startInfo.CreateNoWindow = true;
            Process.Start(startInfo);

            }
	}
	} 