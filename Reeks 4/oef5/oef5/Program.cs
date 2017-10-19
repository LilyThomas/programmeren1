using System;

namespace oef5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Getal?");
            String number = Console.ReadLine();

            if(number.Length <= 4)
            {
                Console.WriteLine("Lenght of number is " + number.Length);
            }
            else
            {
                Console.WriteLine("Length of number is greather than 4");
            }
        }
    }
}
