using System;

namespace Stripwinkel
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const int COMIC_PRICE = 5;
            const double BTW = 0.06;

            Console.WriteLine("Wat is je naam?");
            string name = Console.ReadLine();

            Console.WriteLine("Geef het aantal strips in: ");
            int nrOfComics = int.Parse(Console.ReadLine());

            int comicPrice = nrOfComics * COMIC_PRICE;

            Console.WriteLine("#######################################");
            Console.WriteLine("U wordt geholpen door " + name);
            Console.WriteLine("Eenheidsprijs exclusief BTW = " + COMIC_PRICE + " EUR");
            Console.WriteLine("Aantal = " + nrOfComics);
            Console.WriteLine("Subtotaal exclusief BTW = " + comicPrice);
            Console.WriteLine("BTW-tarief = " + (BTW * 100) + " %");
            Console.WriteLine("BTW bedrag = " + (comicPrice * BTW) + " EUR");
            Console.WriteLine("Totaal inclusief BTW = " + (comicPrice + (comicPrice * BTW)) + " EUR");
        }
    }
}
