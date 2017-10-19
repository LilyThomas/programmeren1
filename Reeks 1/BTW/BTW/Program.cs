using System;

namespace _BTW
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			const double BTW = 0.21;

			Console.WriteLine("Bedrag?");
			double bedragZonderBTW = double.Parse(Console.ReadLine());

			Console.WriteLine("BTW bedraagt: " + Math.Round(bedragZonderBTW * BTW, 2));
			Console.WriteLine("Totaal bedrag: " + Math.Round((bedragZonderBTW + bedragZonderBTW * BTW), 2));
		}
	}
}
