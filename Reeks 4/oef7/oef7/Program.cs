using System;
using System.Collections;

namespace oef7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Getal?");
            int getal = int.Parse(Console.ReadLine());

            Console.WriteLine(getal.ToString("X"));
        }
    }
}
