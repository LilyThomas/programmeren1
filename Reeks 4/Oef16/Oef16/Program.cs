using System;

namespace Oef16
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			int getal1 = 1, getal2 = 0;

			while (getal1 > getal2)
			{
				getal2 = getal1;
				getal1 = int.Parse(Console.ReadLine());
        }
    }
}
