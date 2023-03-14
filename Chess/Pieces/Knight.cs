namespace Chess.Pieces;

public class Knight : IPiece
{
    public int Colour { get; }

    public bool OnBoard { get; set; }
    public Knight(int colour)
    {
        Colour = colour;
        OnBoard = true;
    }

    public List<(int, int)> GetPossibleMoves((int, int) currentPosition) => new List<(int, int)>
    {
            // |_ or _| rotations (2 NESW, 1 perpendicular)
        };
}