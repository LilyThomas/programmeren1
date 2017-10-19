using System;

namespace Oef15
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			int getal = int.Parse(Console.ReadLine());
			int min = getal;
			int minCount = 1;

			while (getal != -32768)
			{
				if (getal < min)
				{
					min = getal;
                    minCount = 1;
				}
				else if (getal == min)
				{
                    minCount++;
				}

				getal = int.Parse(Console.ReadLine());
			}


			Console.WriteLine(min);
			Console.WriteLine(minCount);
		}
    }
}
