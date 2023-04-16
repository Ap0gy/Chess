namespace Chess.Pieces;

public record Pawn(Colour colour, Coords position) : Piece(colour, position)
{
    public bool HasMoved { get; set; }
    public bool MovedTwoSquaresLastMove { get; set; }

    public IEnumerable<(DirectionChange directionChange, int distance)> GetDirections()
    { 
        yield return (Direction.North.GetDirectionChange(), HasMoved ? 1 : 2);
    }

    public IEnumerable<(DirectionChange directionChange, int distance)> GetAttackingDirections() => new[]
    {
        (Direction.NorthWest.GetDirectionChange(), 1),
        (Direction.NorthEast.GetDirectionChange(), 1)
    };
}

public enum Direction
{
    North,
    South,
    East,
    West,
    NorthWest,
    SouthWest,
    NorthEast,
    SouthEast
}

public static class DirectionExtensions
{
    public static DirectionChange GetDirectionChange(this Direction direction) => direction switch
    {
        Direction.North => (Coords coord) => coord with { x = coord.x + 1 },





        _ => throw new NotImplementedException()
    };
}