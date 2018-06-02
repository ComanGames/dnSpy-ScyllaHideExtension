using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;
using Timer = System.Timers.Timer;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace DebbugingDetttectionTesting
{
	class Program
	{
		static void Main(string[] args)
		{
			Timer timer = new Timer(500);
			timer.Elapsed += TimerElepsed;
			timer.Start();
			Console.WriteLine("Timer Started");
			Console.ReadLine();
		}

		private static void TimerElepsed(object sender, ElapsedEventArgs e)
		{
			DebugingInfo();	
		}

		private static void DebugingInfo()
		{

			bool isAttached = Debugger.IsAttached;
			bool isPresent = IsDebuggerPresent();
			Console.Write($"Debugger is Attached:");
			TrueOrFalse(isAttached);

			Console.Write($"Debugger is Present:");
			TrueOrFalse(isPresent);

			Console.WriteLine();
		}

		private static void TrueOrFalse(bool isAttached)
		{
			if (isAttached)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("True");
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("False");
			}

			Console.ForegroundColor = ConsoleColor.White;
		}

		[DllImport("kernel32.dll")]
		private static extern bool IsDebuggerPresent();

	}
}
