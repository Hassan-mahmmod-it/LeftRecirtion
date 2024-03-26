using System;
using System.IO;
namespace app
{
	class programm
	{
		static void Main(string[] args)

		{
			string n = File.ReadAllText(@"C:\Users\Zainab\Desktop\tx.txt");
			Console.WriteLine("--------------(Basic Production's)--------------");
			for (int i = 0; i < n.Length; i++)
				Console.Write(n[i]);
			Console.WriteLine("\n" + "--------------(Left Recurtion)------------------");
			char[] p = n.ToCharArray();
			char[] z = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'Y', 'V', 'W', 'X', 'U', 'Z' };
			char c;

			for (int i = 1; i < p.Length; i++)
			{
				for (int j = 0; j < z.Length; j++)
					if (p[i] == z[j])
					{
						j++;
						p[i] = z[j];
					}
			}
			for (int i = 4; i < p.Length; i++)
			{
				for (int j = 5; j < p.Length; j++)
				{
					c = p[i];
					p[i] = p[j];
					p[j] = c;
					break;
				}
				break;
			}
			for (int j = 0; j < p.Length; j++)
				Console.Write(p[j]);

			Console.Write("lift:");
			//chack



			Console.ReadKey();
		}
	}
}
