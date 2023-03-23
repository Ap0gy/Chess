using Chess.Pieces;

namespace Chess;


public sealed class Board : IDisposable
{
    Dictionary<Coords, Piece> chessBoard = new Dictionary<Coords, Piece>();

    public void DisplayBoard()
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

    public void AddPiece (Coords coordinate, Piece piece)
    {
        if (chessBoard.ContainsKey(coordinate) is false)
        {
            chessBoard.Add(coordinate, piece);
        }
    }
    
    public void RemovePiece(Coords coordinate)
    {
        chessBoard.Remove(coordinate);
    }
    
    public void Dispose()
    {
        GC.Collect();
    }

}

public class PieceMovesVisualizer
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

