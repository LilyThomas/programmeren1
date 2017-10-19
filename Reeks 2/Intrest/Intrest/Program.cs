using System;

namespace Intrest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const double INTREST = 0.0175;
            const int DECEMBER = 12;
            const int LAST_DAY = 31;

            Console.WriteLine("Welk bedrag stort u?");
            double deposit = double.Parse(Console.ReadLine());

            DateTime today = DateTime.Today;
            DateTime tomorrow = today.AddDays(1);
            DateTime newYear = new DateTime(today.Year, DECEMBER, LAST_DAY);

            TimeSpan dayDifference = newYear - tomorrow;
            double nrOfDays = Math.Round(dayDifference.TotalDays);

            Console.WriteLine("Interst in een jaar " + (deposit * ((INTREST/365)*nrOfDays)));

        }
    }
}
