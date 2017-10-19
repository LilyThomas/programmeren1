using System;

namespace Telefoonnummer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();

            const int FIRST = 3;
            const int THIRD = 4;
            String result = "";

            for (int i = 0; i < FIRST; i++)
            {
                result += "" + rnd.Next(0, 8);
            }

            result += "-";

            int two = rnd.Next(743);
            result += two.ToString("000");

            result = result + "-";

            for (int i = 0; i < THIRD; i++)
            {
                result += rnd.Next(0, 10);
            }

            Console.Write(result);
        }
    }
}
