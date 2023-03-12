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

    public List<int[,]> GetPossibleMoves(int[,] currentPosition) => new List<int[,]>
        {
            new int[currentPosition[0, 0] + 1, currentPosition[1, 0]],
            new int[currentPosition[0, 0] - 1, currentPosition[1, 0]],

            new int[currentPosition[0, 0], currentPosition[1, 0] + 1],
            new int[currentPosition[0, 0], currentPosition[1, 0] - 1],

            new int[currentPosition[0, 0] -1, currentPosition[1, 0] + 1],
            new int[currentPosition[0, 0] -1, currentPosition[1, 0] - 1],

            new int[currentPosition[0, 0] + 1, currentPosition[1, 0] + 1],
            new int[currentPosition[0, 0] + 1, currentPosition[1, 0] - 1],

            new int[currentPosition[0, 0] + 2, currentPosition[1, 0]],
            new int[currentPosition[0, 0] + 2, currentPosition[1, 0]]
        };
}