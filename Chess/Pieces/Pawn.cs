namespace Chess.Pieces;

public record Pawn(Colour colour, Coords position) : Piece(colour, position)
{
    public bool HasMoved { get; set; }
    public bool MovedTwoSquaresLastMove { get; set; }
}