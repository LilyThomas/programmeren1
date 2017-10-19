using System;

namespace Oef28
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = 0;
            int b = 0;


            Console.WriteLine("a==========");
            for (int i = 0; i < 30; i++)
            {
                a += 6;
                Console.WriteLine(a);
            }


			Console.WriteLine("b==========");
			for (int i = 0; i < 30; i++)
			{
				b += 8;
				Console.WriteLine(b);
			}
        }
    }
}
