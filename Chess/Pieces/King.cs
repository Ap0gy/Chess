namespace Chess.Pieces;

public class King : IPiece
{
    public int Colour { get; }

    public bool HasMoved { get; set; }

    public bool OnBoard { get; set; }
    public King(int colour)
    {
        Colour = colour;
        OnBoard = true;
        HasMoved = false;
    }

    public List<(int, int)> GetPossibleMoves((int, int) currentPosition) => new List<(int, int)>
    {
            //1 adjacent square any direction
        };
}