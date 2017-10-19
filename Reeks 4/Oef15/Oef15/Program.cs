using System;

namespace Oef15
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const int END_VALUE = -32768;
			int getal;
            int min = 9999;
			int minCount = 0;

			do
			{
				Console.WriteLine("Number?");
				getal = int.Parse(Console.ReadLine());

                if (getal < min )
				{
					min = getal;
                    minCount = 1;
				}
				else if (getal == min && getal != END_VALUE)
				{
                    minCount++;
				}
			} while (getal != END_VALUE);

			if (min == END_VALUE)
			{
				min = 0;
			}

			Console.WriteLine(min);
            Console.WriteLine(minCount);
		}
    }
}
