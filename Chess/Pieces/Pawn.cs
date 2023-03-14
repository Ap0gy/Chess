namespace Chess.Pieces;

public class Pawn : IPiece
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

    public List<(int, int)> GetPossibleMoves((int, int) currentPosition) => new List<(int, int)>
    {
            //Two forward (if not moved)
            //One forward
            //One diagonal forward (if taking)
            //En passant?
        };
}