using System;

namespace Oef42
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int day;
            int month;

            Console.WriteLine("Year?");
            int year = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Month?");
                month = int.Parse(Console.ReadLine());
            } while (month < 1 || month > 12);

            do
            {
                Console.WriteLine("Day?");
                day = int.Parse(Console.ReadLine());
            } while (day < 1 || day > DateTime.DaysInMonth(year, month));

            DateTime givenDay = new DateTime(year, month, day);

            Console.WriteLine("Number of days is " + givenDay.DayOfYear);

        }
    }
}
