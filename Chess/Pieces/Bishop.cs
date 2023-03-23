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

    public List<Coords> GetPossibleMoves(Coords piecePosition)
    {
        return new List<Coords>();
        //any diagonal (1x1, 2x2, -1x-1 etc)
            
    }
}