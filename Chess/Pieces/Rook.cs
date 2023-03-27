namespace Chess.Pieces;

public class Rook
{
    public int Colour { get; }

    public bool HasMoved { get; set; }

    public bool OnBoard { get; set; }
    public Rook(int colour)
    {
        Colour = colour;
        OnBoard = true;
        HasMoved = false;
    }

    public List<Coords> GetPossibleMoves(Coords piecePosition)
    {
        return new List<Coords>();
        //+
    }
}