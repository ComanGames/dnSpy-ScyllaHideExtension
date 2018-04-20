using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using dnSpy.Contracts.App;
using dnSpy.Contracts.Debugger;
using dnSpy.Contracts.Debugger.References;

namespace dnSpy.ScyllaHide {
	[Export(typeof(IDbgManagerStartListener))]
	sealed class DebugStart:IDbgManagerStartListener {
		public static SynchronizationContext main;
		public static DbgManager dbg;
		public void OnStart(DbgManager dbgManager) {

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
			string scyllaProg = @"C:\MyPograms\ScyllaHide\InjectorCLIx64.exe";

			ProcessStartInfo startInfo = new ProcessStartInfo();
			startInfo.FileName = scyllaProg;
			string dll = @"C:\MyPograms\ScyllaHide\HookLibraryx64.dll";	
			startInfo.Arguments = $"pid:{proccessId} {dll}";
			startInfo.CreateNoWindow = true;
			Process.Start(startInfo);
		}
	}
}
