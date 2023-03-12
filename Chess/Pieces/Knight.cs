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

    public List<int[,]> GetPossibleMoves(int[,] currentPosition) => new List<int[,]>
        {
            new int[currentPosition[0, 0] + 1, currentPosition[1, 0] - 2],
            new int[currentPosition[0, 0] + 1, currentPosition[1, 0] + 2],
            new int[currentPosition[0, 0] + 2, currentPosition[1, 0] + 1],
            new int[currentPosition[0, 0] + 2, currentPosition[1, 0] - 1],
            new int[currentPosition[0, 0] - 1, currentPosition[1, 0] + 2],
            new int[currentPosition[0, 0] - 1, currentPosition[1, 0] - 2],
            new int[currentPosition[0, 0] + 2, currentPosition[1, 0] + 1],
            new int[currentPosition[0, 0] + 2, currentPosition[1, 0] - 1]
        };
}