namespace Chess.Pieces;

public class Pawn
{
    public int Colour { get; } //white = 1, black = -1

    public bool HasMoved { get; set; }

    public bool OnBoard { get; set; }
    public Pawn(int colour)
    {
        Colour = colour;
        OnBoard = true;
        HasMoved = false;
    }

    public List<Coords> GetPossibleMoves(Coords piecePosition)
    {
        return new List<Coords>();
        //Two forward (if not moved)
        //One forward
        //One diagonal forward (if taking)
        //En passant?
    }
}