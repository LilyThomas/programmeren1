using System;

namespace Oef19
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int voorlaatstegetal = int.Parse(Console.ReadLine());
            int getal = int.Parse(Console.ReadLine());

            if (voorlaatstegetal < getal)
            {
                do
                {
                    voorlaatstegetal = getal;
                    getal = int.Parse(Console.ReadLine());

                } while (getal > voorlaatstegetal && getal != 0);
            }
        }
    }
}
