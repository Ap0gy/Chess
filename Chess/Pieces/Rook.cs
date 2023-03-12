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

    public List<int[,]> GetPossibleMoves(int[,] currentPosition) => new List<int[,]>
        {
            new int[currentPosition[0, 0] + 1, currentPosition[1, 0]],
            new int[currentPosition[0, 0] + 2, currentPosition[1, 0]],
            new int[currentPosition[0, 0] + 3, currentPosition[1, 0]],
            new int[currentPosition[0, 0] + 4, currentPosition[1, 0]],
            new int[currentPosition[0, 0] + 5, currentPosition[1, 0]],
            new int[currentPosition[0, 0] + 6, currentPosition[1, 0]],
            new int[currentPosition[0, 0] + 7, currentPosition[1, 0]],

            new int[currentPosition[0, 0] - 1, currentPosition[1, 0]],
            new int[currentPosition[0, 0] - 2, currentPosition[1, 0]],
            new int[currentPosition[0, 0] - 3, currentPosition[1, 0]],
            new int[currentPosition[0, 0] - 4, currentPosition[1, 0]],
            new int[currentPosition[0, 0] - 5, currentPosition[1, 0]],
            new int[currentPosition[0, 0] - 6, currentPosition[1, 0]],
            new int[currentPosition[0, 0] - 7, currentPosition[1, 0]],

            new int[currentPosition[0, 0], currentPosition[1, 0] + 1],
            new int[currentPosition[0, 0], currentPosition[1, 0] + 2],
            new int[currentPosition[0, 0], currentPosition[1, 0] + 3],
            new int[currentPosition[0, 0], currentPosition[1, 0] + 4],
            new int[currentPosition[0, 0], currentPosition[1, 0] + 5],
            new int[currentPosition[0, 0], currentPosition[1, 0] + 6],
            new int[currentPosition[0, 0], currentPosition[1, 0] + 7],

            new int[currentPosition[0, 0], currentPosition[1, 0] - 1],
            new int[currentPosition[0, 0], currentPosition[1, 0] - 2],
            new int[currentPosition[0, 0], currentPosition[1, 0] - 3],
            new int[currentPosition[0, 0], currentPosition[1, 0] - 4],
            new int[currentPosition[0, 0], currentPosition[1, 0] - 5],
            new int[currentPosition[0, 0], currentPosition[1, 0] - 6],
            new int[currentPosition[0, 0], currentPosition[1, 0] - 7],
        };
}