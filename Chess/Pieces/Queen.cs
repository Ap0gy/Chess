namespace Chess.Pieces;

public class Queen
{
    public int Colour { get; }

    public bool OnBoard { get; set; }

    public Queen(int colour)
    {
        Colour = colour;
        OnBoard = true;
    }

    public List<Coords> GetPossibleMoves(Coords piecePosition)
    {
        return new List<Coords>();
       //rook + bishop
    }
}