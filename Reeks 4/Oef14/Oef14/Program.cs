using System;

namespace Oef14
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const int END_VALUE = -32768;
            int getal;
            int max = END_VALUE;
            int maxCount = 0;

            do
            {
                Console.WriteLine("Number?");
                getal = int.Parse(Console.ReadLine());

                if (getal > max || max == END_VALUE)
                {
                    max = getal;
                    maxCount = 1;
                }
                else if (getal == max && getal != END_VALUE)
                {
                    maxCount++;
                }
            } while (getal != END_VALUE);

            Console.WriteLine(max);
            Console.WriteLine(maxCount);
        }
    }
}
