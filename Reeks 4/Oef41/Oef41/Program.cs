using System;

namespace Oef41
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int i = 10; i < 100; i++)
            {
                int divisor = (i % 10) + (i / 10);
                if(i % divisor == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
