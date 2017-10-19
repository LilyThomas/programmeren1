using System;

namespace Balk
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hoogte:");
			double hoogte = double.Parse(Console.ReadLine());
			Console.WriteLine("Breedte:");
			double breedte = double.Parse(Console.ReadLine());
			Console.WriteLine("Lengte:");
			double lengte = double.Parse(Console.ReadLine());

			Console.WriteLine("Lengte: " + lengte);
			Console.WriteLine("Breedte: " + breedte);
			Console.WriteLine("Hoogte: " + hoogte);
			Console.WriteLine(("Oppervlakte: ") + (2 * ((lengte * breedte) + (lengte * hoogte) + (hoogte * breedte))));
			Console.WriteLine("Inhoud: " + (lengte * breedte * hoogte));
		}
	}
}
