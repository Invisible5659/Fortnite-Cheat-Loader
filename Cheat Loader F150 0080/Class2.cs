using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace Cheat_Loader_ION_FN
{
	// Token: 0x02000003 RID: 3
	internal class Class2
	{
		// Token: 0x06000004 RID: 4 RVA: 0x000021E0 File Offset: 0x000003E0
		public static void Tester()
		{
			int num = 80;
            _ = (new char[62]);
			char[] array = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
			RandomNumberGenerator randomNumberGenerator = new RNGCryptoServiceProvider();
			byte[] array2 = new byte[num];
			randomNumberGenerator.GetNonZeroBytes(array2);
			StringBuilder stringBuilder = new StringBuilder(num);
			foreach (byte b in array2)
			{
				stringBuilder.Append(array[(int)b % (array.Length - 1)]);
			}
			Console.Title = (((stringBuilder != null) ? stringBuilder.ToString() : null) ?? "");
			new Thread(new ThreadStart(Class2.Tester)).Start();
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000227C File Offset: 0x0000047C
		public static void Print(string message, int sec = 40)
		{
			for (int i = 0; i < message.Length; i++)
			{
				Console.Write(message[i]);
				Thread.Sleep(sec);
			}
		}
	}
}
