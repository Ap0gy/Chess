namespace Chess.Pieces;

public class Knight
{
    public int Colour { get; }

    public bool OnBoard { get; set; }
    public Knight(int colour)
    {
        Colour = colour;
        OnBoard = true;
    }

    public List<Coords> GetPossibleMoves(Coords piecePosition)
    {
        return new List<Coords>();
        // |_ or _| rotations (2 NESW, 1 perpendicular)
    }
}