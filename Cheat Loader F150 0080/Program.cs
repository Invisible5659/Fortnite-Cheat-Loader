using System;
using System.Threading;

namespace Cheat_Loader_ION_FN
{
	// Token: 0x02000005 RID: 5
	internal class Program
	{
		// Token: 0x06000008 RID: 8 RVA: 0x000022B0 File Offset: 0x000004B0
		private static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Class2.Tester();
			Console.WriteLine("Change the code of this shit!", Environment.UserName);
			Thread.Sleep(2000);
			Console.Clear();
			Console.WriteLine("Pasted Shit");
			Console.WriteLine(" ");
			Class2.Print("         Mapping Driver", 40);
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(" | Downloaded Files");
			Class1.inj();
			Thread.Sleep(2000);
			Class2.Print("You can close the mapper now", 40);
			Class2.Print("\nMapped", 40);
			Class2.Print("\n\nClosing Application", 40);
			Thread.Sleep(500);
			Environment.Exit(-1);
		}
	}
}
