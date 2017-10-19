using System;

namespace oef45
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int controlNumber = rnd.Next();
            int nrSum = 0;

            Console.WriteLine("number?");
            string strNr = Console.ReadLine();
            int number = int.Parse(strNr);

            if(strNr.Length > 1)
            {
                while(number != 0)
                {
                    nrSum += number % 10;
                    number /= 10;
                }
            }
        }
    }
}
