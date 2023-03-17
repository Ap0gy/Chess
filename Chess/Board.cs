namespace Chess;

public class Board
{

    private Board()
    {
        Dictionary<Coords, Piece> chessBoard = new Dictionary<Coords, Piece>();
    }
    
    public void DisplayBoard()
    {
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

