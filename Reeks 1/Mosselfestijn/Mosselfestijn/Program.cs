using System;

namespace Mosselfestijn
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const int FRIET_PRIJS = 20;
            const int KONINGINNEHAPJE_PRIJS = 10;
            const int NAGERECHT_PRIJS = 3;
            const int DRANK_PRIJS = 2;

            int result = 0;
            Console.WriteLine("Frietjes?");
            result += FRIET_PRIJS * int.Parse(Console.ReadLine());
            Console.WriteLine("Koninginnehapje?");
            result += KONINGINNEHAPJE_PRIJS * int.Parse(Console.ReadLine());
            Console.WriteLine("Nagerecht?");
            result += NAGERECHT_PRIJS * int.Parse(Console.ReadLine());
            Console.WriteLine("Drankje?");
            result += DRANK_PRIJS * int.Parse(Console.ReadLine());

            Console.WriteLine("Dat is dan: " + result);
        }
    }
}
