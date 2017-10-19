using System;

namespace Munten
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			double result = 0;

			Console.WriteLine("Aantal 2 euro munten?");
			result += (2 * double.Parse(Console.ReadLine()));
			
            Console.WriteLine("Aantal 1 euro munten?");
			result += double.Parse(Console.ReadLine());
			
            Console.WriteLine("Aantal 50 cent munten?");
			result += (0.50 * double.Parse(Console.ReadLine()));
			
            Console.WriteLine("Aantal 20 cent munten?");
			result += (0.20 * double.Parse(Console.ReadLine()));
			
            Console.WriteLine("Aantal 10 cent munten?");
			result += (0.10 * double.Parse(Console.ReadLine()));
			
            Console.WriteLine("Aantal 5 cent munten?");
			result += (0.05 * double.Parse(Console.ReadLine()));
			
            Console.WriteLine("Aantal 2 cent munten?");
			result += (0.02 * double.Parse(Console.ReadLine()));
			
            Console.WriteLine("Aantal 1 cent munten?");
			result += (double.Parse(Console.ReadLine()) / 100);

			Console.WriteLine("Het bedrag is: " + result);
		}
	}
}
