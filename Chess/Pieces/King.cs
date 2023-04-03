namespace Chess.Pieces;

public record King(Colour colour, Coords position) : Piece(colour, position)
{
    public bool HasMoved { get; set; }
    public Coords InCheck { get; set; }
}