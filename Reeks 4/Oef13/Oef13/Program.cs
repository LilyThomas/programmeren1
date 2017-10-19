using System;

namespace Oef13
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int getal;
            int result = 0;
            int count = 0;

            do
            {
                Console.WriteLine("Positive number?");
                getal = int.Parse(Console.ReadLine());
                count++;
                result += getal;
                if (getal < 0)
                {
                    count--;
                    result -= getal;
                }
            } while (getal > 0);

            Console.WriteLine(result/count);
        }
    }
}
