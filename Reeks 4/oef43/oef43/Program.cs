using System;

namespace oef43
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const int END_SCORE = 15;
            int scoreA = 0;
            int scoreB = 0;

            while(scoreA != END_SCORE && scoreB != END_SCORE)
            {
                Console.WriteLine("Who got a point? A or B?");
                string winner = Console.ReadLine();

                switch(winner)
                {
                    case "A" :
                        scoreA++;
                        break;
                    case "B":
                        scoreB++;
                        break;
                }

                Console.WriteLine("score A is " + scoreA);
                Console.WriteLine("score B is " + scoreB);
            }


        }

    }
}
