using System;

namespace Oef12
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int result = 0;

            Console.WriteLine("number?");
            int getal = int.Parse(Console.ReadLine());

           
            do
            {
                result += getal % 10;
                getal /= 10;
            } while (getal != 0);


            Console.WriteLine(result);
        }
    }
}
