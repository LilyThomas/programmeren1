using System;
using System.Collections;

namespace oef3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            String strChar = "";

            do
            {
                Console.WriteLine("Character?");
                strChar = Console.ReadLine();
            }
            while (strChar.Length != 1);
            {
				Console.WriteLine("Character?");
				strChar = Console.ReadLine();
            }

            char character = char.Parse(strChar);

            if(char.IsNumber(character))
            {
                Console.WriteLine("Character is number");
            }
            else if(char.IsLower(character))
            {
                Console.WriteLine("Character is lowercase letter");
            }
            else if(char.IsUpper(character))
            {
                Console.WriteLine("Character is uppercase letter");
            }
            else if(char.IsControl(character))
            {
                Console.WriteLine("Character is an operator");
            }


        }
    }
}
