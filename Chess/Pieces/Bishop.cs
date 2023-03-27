namespace Chess.Pieces;

public record Bishop(Colour colour, Coords position) : Piece(colour, position)
{   
    public List<Coords> GetPossibleMoves(Coords piecePosition)
    {
        return new List<Coords>();
        //any diagonal (1x1, 2x2, -1x-1 etc)
    }
}