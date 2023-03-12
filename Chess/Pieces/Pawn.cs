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

    public List<int[,]> GetPossibleMoves(int[,] currentPosition) => new List<int[,]>
        {
            new int[currentPosition[0 , 0], currentPosition[1 , 0] + Colour],
            new int[currentPosition[0 , 0], currentPosition[1 , 0] + 2*Colour],
            new int[currentPosition[0 , 0] + 1, currentPosition[1 , 0] + Colour],
            new int[currentPosition[0 , 0] - 1, currentPosition[1 , 0] + Colour]
        };
}