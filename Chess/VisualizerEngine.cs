using Chess.Pieces;

namespace Chess;

public class VisualizerEngine
{
    public static void DisplayLegalMoves(List<Coords> possibleMovesCollection)
    {
        for (var y = 7; y > -1; y--)
        {
            Console.Write("|");
            for (var x = 0; x < 8; x++)
            {
                if (possibleMovesCollection.Contains(new Coords(x, y)))
                {
                    Console.Write("x");
                }

                if (!possibleMovesCollection.Contains(new Coords(x, y)))
                {
                    Console.Write("-");
                }
                Console.Write("|");
            }
            Console.WriteLine();
        }
    }
    public static void DisplayBoard(Dictionary<Coords, Piece> chessBoard)
    {
        for (var y = 7; y > -1; y--)
        {
            Console.Write("|");
            for (var x = 0; x < 8; x++)
            {
                if (chessBoard.ContainsKey(new Coords(x, y)))
                {
                    Console.Write("x");
                }

                if (!chessBoard.ContainsKey(new Coords(x, y)))
                {
                    Console.Write("-");
                }

                Console.Write("|");
            }

            Console.WriteLine();
        }
    }


}
