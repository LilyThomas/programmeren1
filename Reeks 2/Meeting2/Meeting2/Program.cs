using System;

namespace Meeting2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("De meeting met London gaat door in: ");
            String invCity = Console.ReadLine();
            Console.WriteLine("Hoeveel uur tijdsverschil?");

            int timeDifference = int.Parse(Console.ReadLine());
            Console.WriteLine("Startuur in London?");
            int startuurLondon = int.Parse(Console.ReadLine());

            DateTime london = DateTime.Today.AddHours(startuurLondon);
            DateTime city = london.AddHours(timeDifference);

            Console.WriteLine("Meeting in London: " + london.ToShortDateString() + " " + london.ToString("HH:mm:ss"));
            Console.WriteLine("Tijdsverschil met " + invCity + " is " + city.ToString("HH:mm:ss"));
            Console.WriteLine("Meeting in " + invCity + ": " + city.ToString("HH:mm:ss"));

        }
    }
}
