using System;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlienRekenmachine
{
	class Program
	{
		static void Main(string[] args)
		{
			const int STELSEL = 8;
			string nieuwgetal = "";

			Console.Write("Geef een positief geheel getal van 3 cijfers    ");
			double getal = int.Parse(Console.ReadLine());

			while (getal != 0)
			{
				if (getal < STELSEL)
				{
					nieuwgetal = nieuwgetal + getal;
					getal = 0;
				}
				else
				{
					nieuwgetal = nieuwgetal + Math.Floor(getal / STELSEL);
					getal = Math.Ceiling(getal % STELSEL);
				}
			}

			Console.WriteLine("Getal    " + nieuwgetal);



		}
	}
}
