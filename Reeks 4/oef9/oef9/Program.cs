using System;

namespace Oef9
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const int END_VALUE = 0;

            int negative = 0;
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
                else if(getal > 0)
                {
                    positive++;
                }
            } while (getal != END_VALUE);

            Console.WriteLine(positive);
            Console.WriteLine(negative);
        }
    }
}
