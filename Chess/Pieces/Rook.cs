namespace Chess.Pieces;

public class Rook : IPiece
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

    public List<(int, int)> GetPossibleMoves((int, int) currentPosition) => new List<(int, int)>
    {
            //+
        };
}