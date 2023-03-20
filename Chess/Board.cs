namespace Chess;

public class Board
{

    private Board()
    {
        Dictionary<Coords, Piece> chessBoard = new Dictionary<Coords, Piece>();
    }
    
    public static void DisplayBoard(Dictionary<Coords, Piece> locationCollection)
    {
        for (var y = 7; y > -1; y--)
        {
            Console.Write("|");
            for (var x = 0; x < 8; x++)
            {
                if ( locationCollection.ContainsKey(new Coords(x, y)))
                {
                    Console.Write("x");
                }

                if (!locationCollection.ContainsKey(new Coords(x, y)))
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

public interface IPiece
{
}

public enum Colour
{
    Black, White
}

