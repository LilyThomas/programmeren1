using System;

namespace Oef11
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const int END_VALUE = 0;
            int getal;
            int result = 1;

            do
            {
                Console.WriteLine("Number?");
                getal = int.Parse(Console.ReadLine());

                if(getal != 0)
                {
                    result *= getal;
                }
            }while (getal != END_VALUE);

            Console.WriteLine(result);
        }
    }
}
