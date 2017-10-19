using System;

namespace Seconden
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Aantal seconden:");
			double seconds = double.Parse(Console.ReadLine());

			double sec = seconds % 60;
			double min = ((seconds - sec) / 60) % 60;
			double hour = (seconds - sec - 60 * min) / 3600;

			Console.WriteLine(hour + ":" + min + ":" + sec);
		}
	}
}
