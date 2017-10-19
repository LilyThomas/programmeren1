using System;

namespace RandomDatum
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            

            Random rnd = new Random();
            int year = DateTime.Today.Year + 1;
            int month = rnd.Next(1, 13);
            int day = rnd.Next(1, DateTime.DaysInMonth(year, month));

            DateTime date = new DateTime(year, month, day);

            Console.WriteLine(date.ToShortDateString());
            Console.WriteLine(date.ToString("dd/MM/yyyy"));
        }
    }
}
