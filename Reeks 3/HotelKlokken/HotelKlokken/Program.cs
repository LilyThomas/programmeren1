using System;

namespace HotelKlokken
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const int TD_NY = 5;
            const int TD_TOK = -9;
            const int TD_HK = -8;

            Random rnd = new Random();

            int hour = rnd.Next(24);
            int minutes = rnd.Next(60);
            int seconds = rnd.Next(60);

            DateTime london = DateTime.Today.AddHours(hour).AddMinutes(minutes).AddSeconds(seconds);

            DateTime newYork = london.AddHours(TD_NY);
            DateTime tokyo = london.AddHours(TD_TOK);
            DateTime hongKong = london.AddHours(TD_HK);

            Console.WriteLine(london.ToShortTimeString());
            Console.WriteLine(newYork.ToLongTimeString());
            Console.WriteLine(tokyo.ToLongTimeString());
            Console.WriteLine(hongKong.ToString("HH:mm:ss"));
        }
    }
}
