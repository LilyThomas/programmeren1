using System;

namespace Oef38
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n;
            double result = 0;

            do
            {
                Console.WriteLine("Number?");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);

            for (int i = 0; i < n + 1; i++)
            {
                result += Math.Pow(i, 2);
            }

            Console.WriteLine(result);
        }
    }
}
