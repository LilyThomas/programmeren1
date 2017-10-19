using System;

namespace Oef21
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number;
            int sum = 0;

            do
            {
                Console.WriteLine("Number?");
                number = int.Parse(Console.ReadLine());
            } while (number < 0);

            for (int i = number; i > 0; i--)
            {
                if(i % 2 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
