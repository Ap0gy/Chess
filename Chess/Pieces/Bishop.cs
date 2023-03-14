using System.Xml.Serialization;

namespace Chess.Pieces;

public class Bishop : IPiece
{
    public int Colour { get; }

    public bool OnBoard { get; set; }
    public Bishop(int colour)
    {
        Colour = colour;
        OnBoard = true;
    }

    public List<(int, int)> GetPossibleMoves((int, int) currentPosition) => new List<(int, int)>
    {
            //any diagonal (1x1, 2x2, -1x-1 etc)
        };
}