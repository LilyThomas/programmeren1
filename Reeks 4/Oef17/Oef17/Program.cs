using System;

namespace Oef17
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number;
            int zeroCount = 0;
            int count = 0;
            int sum = 0;

            do
            {
                Console.WriteLine("Number?");
                number = int.Parse(Console.ReadLine());
                sum += number;

                if (number != 0)
                {
                    count++;
                    zeroCount = 0;
                }
                else
                {
                    zeroCount++;
                }
            } while (zeroCount != 2);

            Console.WriteLine(sum/count);
        }
    }
}
