namespace Chess.Pieces;

public class Queen : IPiece
{
    public int Colour { get; }

    public bool OnBoard { get; set; }

    public Queen(int colour)
    {
        Colour = colour;
        OnBoard = true;
    }

    public List<int[,]> GetPossibleMoves(int[,] currentPosition) => new List<int[,]>
        {
           
        };
}