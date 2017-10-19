using System;

namespace oef4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            String number = "";
            do
            {
                Console.WriteLine("Getal?");
                number = Console.ReadLine();
            }
            while (number.Length > 4 || number.Length == 0);


            Console.WriteLine("Length of number is " + number.Length);
        }
    }
}
