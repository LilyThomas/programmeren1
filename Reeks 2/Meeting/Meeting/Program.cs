using System;

namespace Meeting
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const int TIME_DIFFERENCE = -5;

            DateTime london = DateTime.Today.AddHours(14);
            DateTime ny = london.AddHours(TIME_DIFFERENCE);

            //ToString gebruikt ipv ToShortTimeString door instelling van mijn computer.
            //Geeft anders 2:00 pm en de berekening loopt dan ook fout.
            Console.WriteLine("Meeting in London: " + london.ToShortDateString() + " " + london.ToString("HH:mm:ss"));
            Console.WriteLine("New York heeft een tijdsverschil van " + TIME_DIFFERENCE + " uren");
            Console.WriteLine("De meeting in New York is " + ny.ToShortDateString() + " " + ny.ToString("HH:mm:ss");
        }
    }
}
