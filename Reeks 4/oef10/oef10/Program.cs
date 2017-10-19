using System;

namespace Oef10
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const int END_VALUE = -32768;

			int negative = 0;
            int zeros = 0;
			int positive = 0;
			int getal;

            do
            {
                Console.WriteLine("getal?");
                getal = int.Parse(Console.ReadLine());

                if (getal < 0)
                {
                    negative++;
                }
                else if (getal == 0)
                {
                    zeros++;
                }
                else
                {
                    positive++;
                }
            }while (getal != END_VALUE);

			Console.WriteLine(positive);
            Console.WriteLine(zeros);
            Console.WriteLine(negative - 1);
        }
    }
}
