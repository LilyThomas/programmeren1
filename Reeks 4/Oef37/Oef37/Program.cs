using System;

namespace Oef37
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int result = 1;

            int n;
            do
            {
                Console.WriteLine("Number?");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);

            for (int i = n; i > 0; i--)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}
