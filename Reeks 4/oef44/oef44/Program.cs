using System;

namespace oef44
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const int MAX_NR = 100;

            Console.WriteLine("number? (1 positive digit)");
            string number = Console.ReadLine();

            for (int i = MAX_NR; i > 0; i--)
            {
                string powerOfI = Math.Pow(i, 2).ToString();
                string strI = i.ToString();

                if(strI.Contains(number) && powerOfI.Contains(number))
                {
                    Console.WriteLine(strI + "     " + powerOfI);
                }
            }
        }
    }
}

