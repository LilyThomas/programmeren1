using System;

namespace Bibliotheek
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const int CHECKOUTLIMIT = 14;
            Console.WriteLine("Wat is jouw naam?");
            String name = Console.ReadLine();

            DateTime checkOutDate = DateTime.Today;

            Console.WriteLine("Uitlener: " + name);
            Console.WriteLine("Datum uitlenen: " + checkOutDate.ToShortDateString());
            Console.WriteLine("Te houden tot: " + checkOutDate.AddDays(CHECKOUTLIMIT).ToShortDateString());
        }
    }
}
