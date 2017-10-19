using System;

namespace oef2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Getal?");
            int getal = int.Parse(Console.ReadLine());

            if(getal % 8 == 0)
            {
                Console.WriteLine("Deelbaar door 8, 4 en 2");
            }
            else if(getal % 4 == 0)
            {
                Console.WriteLine("Deelbaar door 4 en 2");
            }
            else if(getal % 2 == 0)
            {
                Console.WriteLine("Deelbaar door 2");
            }
            else
            {
                Console.WriteLine("Niet deelbaar door 2, 4 of 8");
            }
        }
    }
}
