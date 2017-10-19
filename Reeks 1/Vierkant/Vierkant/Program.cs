using System;

namespace Vierkant
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Geef de lengte van de zijde:");
			double zijde = double.Parse(Console.ReadLine());

			Console.WriteLine("Zijde: " + zijde);
			Console.WriteLine("Omtrek: " + (zijde * 4));
			Console.WriteLine("Oppervlakte: " + (zijde * zijde));


		}
	}
}
