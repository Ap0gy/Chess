namespace Chess.Pieces;

public interface IPiece
{
    public int Colour { get; }

    public bool OnBoard { get; set; }

    public List<Coords> GetPossibleMoves(Coords piecePosition);
}