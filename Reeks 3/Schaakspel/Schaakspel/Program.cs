using System;

namespace Schaakspel
{
    class MainClass
    {
        public enum PieceColor { Black , White };
        public enum ChessPiece { King, Queen, Bishop, Knight, Rook, Pawn };

		public static void Main(string[] args)
        {
            const int COUNT = 3;
            Random rnd = new Random();
            String result = "";

            for (int i = 0; i < COUNT; i++)
            {
                PieceColor color = (PieceColor)rnd.Next(2);
                ChessPiece piece = (ChessPiece)rnd.Next(6);
                result += color + " " + piece + "\n";
            }

            Console.WriteLine(result);
        }
    }
}
