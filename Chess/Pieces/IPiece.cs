namespace Chess.Pieces;

public interface IPiece
{
    public int Colour { get; }

    public bool OnBoard { get; set; }

    public List<(int, int)> GetPossibleMoves((int, int) currentPosition) => new List<(int, int)> ();

}
