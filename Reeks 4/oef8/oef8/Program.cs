using System;

namespace Oef8
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const int END_VALUE = 0;
            int result = 0;
            int getal;

            do
            {
                Console.WriteLine("Getal?");
                getal = int.Parse(Console.ReadLine());
                result += getal;
            } while (getal != END_VALUE);

            Console.WriteLine(result);
        }
    }
}
