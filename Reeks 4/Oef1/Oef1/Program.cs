using System;

namespace Oef1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Getal?");
            int getal = int.Parse(Console.ReadLine());

            if(getal == 0)
            {
                Console.WriteLine("Getal is nul");
            }
            else if(getal > 0)
            {
                Console.WriteLine("Getal is positief");
            }
            else
            {
                Console.WriteLine("Getal is negatief");
            }
        }
    }
}

