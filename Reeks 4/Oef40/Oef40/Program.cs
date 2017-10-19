using System;

namespace Oef40
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const int END = 10 - 2; 
                
            int first = 0;
            int second = 1;
            int result = 0;

            for (int i = 0; i < END; i++)
            {
                result = first + second;
                first = second;
                second = result;
                Console.WriteLine(result);
            }

            Console.WriteLine(result);
        }
    }
}
