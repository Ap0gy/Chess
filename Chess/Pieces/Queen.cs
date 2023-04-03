namespace Chess.Pieces;

public record Queen(Colour colour, Coords position) : Piece(colour, position)
{
}