using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Threading;
using System.Windows.Threading;
using dnSpy.Contracts.App;
using dnSpy.Contracts.Debugger;

namespace dnSpy.ScyllaHide {


	[Export(typeof(IDbgManagerStartListener))]
	sealed class DebugStart : IDbgManagerStartListener
	{
		public static SynchronizationContext main;
		public static DbgManager dbg;

		[Import]
		protected ScyllaHideSettings ProgrammSettings { get; set; }

	public void OnStart(DbgManager dbgManager) {

		    MsgBox.Instance.Show($"Extension is: {ProgrammSettings.IsEnabledOption}");
            dbg = dbgManager;
			 main = SynchronizationContext.Current;
			dbgManager.DelayedIsRunningChanged += (sender, args) => { ShowCountOfProcesses(dbgManager); };
		}

		private static void ShowCountOfProcesses(DbgManager dbgManager)
		{

			if (dbgManager?.IsRunning==true&&dbgManager.Processes.Length>0) {
				ulong pid = dbgManager.Processes[0].Id;
				StartScyllaDide(pid);
                Thread.Sleep(1000);
			}
		}

		private static void StartScyllaDide(ulong proccessId) {
            string scyllaProg = @"C:\MyPrograms\ScyllaHide\InjectorCLIx64.exe";
            main.Post(o => { MsgBox.Instance.Show("process ID + " + proccessId); } ,null);
			ProcessStartInfo startInfo = new ProcessStartInfo();
			startInfo.FileName = scyllaProg;
			string dll = @"C:\MyPrograms\ScyllaHide\HookLibraryx64.dll";	
			startInfo.Arguments = $"pid:{proccessId} {dll}";
			startInfo.CreateNoWindow = true;
            Process.Start(startInfo);

            }
	}
	} 