using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TryingInjectUsingExternalDll
{
	class Program
	{

		static void Main(string[] args)
		{
			string directory = Environment.CurrentDirectory;
			Console.WriteLine("Current directory is: " + directory);
			Console.WriteLine("Before ");
			ScyllaHideInit(directory);
				Thread.Sleep(500);

			Console.WriteLine("After");

			Console.WriteLine("Please WRite the pid");
			try
			{
				int pid = int.Parse(Console.ReadLine());
				Console.WriteLine("0");
				ScyllaHideDebugLoop(0, pid);
				Thread.Sleep(500);
				Console.WriteLine("1");
				ScyllaHideDebugLoop(1, pid);
				Thread.Sleep(500);
				Console.WriteLine("2");
				ScyllaHideDebugLoop(2, pid);
				Thread.Sleep(500);
				Console.WriteLine("3");
				ScyllaHideDebugLoop(3, pid);
				Thread.Sleep(500);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);

			}



		Console.ReadKey();
		}

		[DllImport("ScyllaHideDnSpyPluginx64.dll", EntryPoint = "ScyllaHideInit", CallingConvention = CallingConvention.Cdecl)]
		private  static extern void ScyllaHideInit([Out, MarshalAsAttribute(UnmanagedType.LPWStr)] string directory);

		[DllImport("ScyllaHideDnSpyPluginx64.dll", CallingConvention = CallingConvention.Cdecl)]

		 private static extern void ScyllaHideReset();

		[HandleProcessCorruptedStateExceptions]
		[SecurityCritical]
		[DllImport("ScyllaHideDnSpyPluginx64.dll", CallingConvention = CallingConvention.Cdecl)]
		private static	extern void ScyllaHideDebugLoop(int DebugEvent, int ProcessID , bool lpStartAddressIsNull= false, bool lpBaseOfNtDll=false);

		private const string DllFilePath = @"ScyllaHideGenericPluginx64.dll";

	}
}
