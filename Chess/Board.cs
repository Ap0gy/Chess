using Chess.Pieces;

namespace Chess;


public sealed class Board
{
    private static readonly Lazy<Board> lazy =
        new Lazy<Board>(() => new Board());

    public static Board Instance { get { return lazy.Value; } }

    private Board()
    {
        Dictionary<Coords, Piece> chessBoard = new Dictionary<Coords, Piece>();
    }
}

public class BoardVisualizer
{
    public static void DisplayPieces(Dictionary<Coords, Piece> locationsCollection)
    {
        for (var y = 7; y > -1; y--)
        {
            Console.Write("|");
            for (var x = 0; x < 8; x++)
            {
                if (locationsCollection.ContainsKey(new Coords(x, y)))
                {
                    Console.Write("x");
                }

                if (!locationsCollection.ContainsKey(new Coords(x, y)))
                {
                    Console.Write("-");
                }
                Console.Write("|");
            }
            Console.WriteLine();
        }
    }

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
}

public record Coords(int x, int y)
{ }


public record Piece(IPiece piece, Colour colour, Coords position)
{
}

public enum Colour
{
    Black, White
}

