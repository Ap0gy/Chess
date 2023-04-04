namespace Chess.Pieces;

public record Rook(Colour colour, Coords position) : Piece(colour, position)
{
    public bool HasMoved { get; set; }
}