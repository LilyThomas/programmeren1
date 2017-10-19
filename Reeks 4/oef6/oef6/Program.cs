using System;
using System.Collections;

namespace oef6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			Console.WriteLine("Character?");
			char character = char.Parse(Console.ReadLine());

			if (char.IsNumber(character))
			{
				Console.WriteLine("Character is number");
			}
			else if (char.IsLower(character))
			{
				Console.WriteLine("Character is lowercase letter");
			}
			else if (char.IsUpper(character))
			{
				Console.WriteLine("Character is uppercase letter");
			}
			else if (char.IsControl(character))
			{
				Console.WriteLine("Character is an operator");
			}
            else
            {
                Console.WriteLine("Character is a differenct character");
            }



		}
    }
}
