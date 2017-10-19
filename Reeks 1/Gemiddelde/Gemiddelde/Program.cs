using System;

namespace Gemiddelde
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Getal 1:");
			double getal1 = double.Parse(Console.ReadLine());
			Console.WriteLine("Getal 2:");
			double getal2 = double.Parse(Console.ReadLine());
			Console.WriteLine("Getal 3:");
			double getal3 = double.Parse(Console.ReadLine());

			double total = getal1 + getal2 + getal3;
			double average = Math.Round(total / 3);

			Console.WriteLine("Het gemiddelde is: " + average);

		}
	}
}
