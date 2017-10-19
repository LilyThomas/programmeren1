using System;

namespace Getallen
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Geef een getal:");
			string firstNr = Console.ReadLine();
			int iFirstNr = int.Parse(firstNr);
			double dFirstNr = double.Parse(firstNr);
			Console.WriteLine("Geef nog een getal:");
			string secondNr = Console.ReadLine();
			int iSecondNr = int.Parse(secondNr);
			double dSecondNr = double.Parse(secondNr);

			Console.WriteLine("De getallen als int");
			Console.WriteLine("De som van beide getallen is: " + (iFirstNr + iSecondNr));
			Console.WriteLine("Het quotiënt van beide getallen is: " + (iFirstNr / iSecondNr));
			Console.WriteLine("---------------------");
			Console.WriteLine("De getallen als double");
			Console.WriteLine("De som van beide getallen is: " + (dFirstNr + dSecondNr));
			Console.WriteLine("Het quotiënt van beide getallen is: " + (dFirstNr / dSecondNr));



		}
	}
}
