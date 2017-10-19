using System;

namespace Oef39
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const int END = 20 - 2;
            int first = 0;
            int second = 2;
            int result = 0;

            Console.WriteLine(first);
            Console.WriteLine(second);

            for (int i = 0; i < END; i++)
            {
                result = first + second;
                first = second;
                second = result;
                Console.WriteLine(result);
            }
        }
    }
}
