using System;

namespace DagenTeller
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DateTime newYears = new DateTime(2017, 12, 31, 23, 59, 59);
            DateTime today = DateTime.Now;

            Console.WriteLine(today.ToShortDateString() + " " + today.ToString("HH:mm:ss"));
            Console.WriteLine(today.ToString(newYears.ToShortDateString() + newYears.ToString("HH:mm:ss")));
            Console.WriteLine("Aantal dagen tot het einde van het jaar: " + Math.Round((newYears - today).TotalDays));
            Console.WriteLine("Korte datum zonder tijd: " + today.ToShortDateString());
            Console.WriteLine("Lange datum zonder tijd: " + today.ToLongDateString());
            Console.WriteLine("Lange datum met korte tijd: " + today.ToShortDateString() + today.ToString("HH:mm:ss"));
            Console.WriteLine("Korte datum met korte tijd: " + today.ToLongDateString() + today.ToString("HH:mm:ss"));

        }
    }
}
