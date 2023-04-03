using Chess.Pieces;

namespace Chess;

public class VisualizerEngine
{
    public static void DisplayMoves(List<Coords> possibleMovesCollection)
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
    public static void DisplayPieces(Dictionary<Coords, Piece> chessBoard)
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

    public static void DisplayPieceAndPossibleMoves(List<Coords> possibleMovesCollection, Coords pieceCoordinate)
    {
        for (var y = 7; y > -1; y--)
        {
            Console.Write("|");
            for (var x = 0; x < 8; x++)
            {
                if (pieceCoordinate.Equals(new Coords(x, y)))
                {
                    Console.Write("o");
                }
                if (possibleMovesCollection.Contains(new Coords(x, y)))
                {
                    Console.Write("x");
                }

                if (!possibleMovesCollection.Contains(new Coords(x, y)) && !pieceCoordinate.Equals(new Coords(x, y)))
                {
                    Console.Write("-");
                }
                Console.Write("|");
            }
            Console.WriteLine();
        }
    }


}
