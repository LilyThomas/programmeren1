using System;

namespace Oef22
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number;
            String stars = "";

            do
            {
                Console.WriteLine("Number?");
                number = int.Parse(Console.ReadLine());
            } while (number < 2 && number > 20);

            for (int i = 0; i < number; i++)
            {
                stars += "*";
                Console.WriteLine(stars);
            }

            stars = "";
            Console.WriteLine("--------------");

            for (int i = number; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    stars += "*";   
                }
                Console.WriteLine(stars);

                stars = "";
            }
			Console.WriteLine("--------------");

			for (int i = 0; i < number; i++)
            {
                int difference = number - i ;
				
                for (int j = 0; j < difference-1; j++)
				{
					stars += " ";
				}
				for (int k = 0; k <= i; k++)
				{
					stars += "*";
				}
                Console.WriteLine(stars);
                stars = "";
            }
			Console.WriteLine("--------------");

			for (int i = number; i > 0; i--)
            {
                int difference = number - i ;

                for (int j = 0; j < difference; j++)
                {
                    stars += " ";
                }
                for (int k = 0; k < i; k++)
                {
                    stars += "*";
                }
                Console.WriteLine(stars);
                stars = "";
            }

        }
    }
}
