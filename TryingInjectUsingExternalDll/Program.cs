using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TryingInjectUsingExternalDll
{
	class Program
	{

		static void Main(string[] args)
		{
			Console.WriteLine("Before ");
			ScyllaHideInit(0,null,"",true);
			Console.WriteLine("After");
			injectDll(0, "");
			Console.ReadKey();
		}
		[DllImport("ScyllaHideGenericPluginx64.dll")]
		private static extern void ScyllaHideInit(int procId, object some, string ddlPath, bool something);

		private const string DllFilePath = @"ScyllaHideGenericPluginx64.dll";

		[DllImport("ScyllaHideGenericPluginx64.dll")]
		private static extern void injectDll(long processId, string dllPath);
	}
}
