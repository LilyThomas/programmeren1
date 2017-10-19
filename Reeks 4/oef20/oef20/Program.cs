using System;

namespace oef20
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const int NR_OF_VALUES = 5;
            int sum = 0;

            for (int i = 0; i < NR_OF_VALUES; i++)
            {
                Console.WriteLine("Number?");
                sum += int.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum/NR_OF_VALUES);
        }
    }
}
