using System;

namespace Bankrekening
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			const int CHECK_NR = 97;

			Console.WriteLine("Geef de eerste 3 cijfers:");
			string three = Console.ReadLine();
			Console.WriteLine("Geef de volgede 7 cijfers:");
			string seven = Console.ReadLine();
			Console.WriteLine("Geef de laatste 2 cijfers:");
			int two = int.Parse(Console.ReadLine());

			long ten = long.Parse(three + seven);

			long result = ten % CHECK_NR;

			Console.WriteLine("bankrekeningnr: " + three + seven + two);

			if (result == two)
			{
				Console.WriteLine("Dit is een geldige bankrekening");
			}
			else
			{
				Console.WriteLine("Dit is een ongeldige bankrekening");
			}



		}
	}
}
