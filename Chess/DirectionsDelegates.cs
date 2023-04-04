using Chess.Pieces;

namespace Chess;

public static class DirectionsDelegates
{
    public static DirectionsDeligate[] GetPieceMovesDeletage(Piece piece) => piece switch
    {

        Bishop => new DirectionsDeligate[]
        {
            (int positionIncriment) => new Coords (piece.position.x + positionIncriment, piece.position.y + positionIncriment),
            (int positionIncriment) => new Coords (piece.position.x + positionIncriment, piece.position.y - positionIncriment),
            (int positionIncriment) => new Coords(piece.position.x - positionIncriment, piece.position.y + positionIncriment),
            (int positionIncriment) => new Coords(piece.position.x - positionIncriment, piece.position.y - positionIncriment)
        },

        Rook => new DirectionsDeligate[]
        {
            (int positionIncriment) => new Coords (piece.position.x + positionIncriment, piece.position.y),
            (int positionIncriment) => new Coords (piece.position.x, piece.position.y + positionIncriment),
            (int positionIncriment) => new Coords (piece.position.x - positionIncriment, piece.position.y),
            (int positionIncriment) => new Coords(piece.position.x, piece.position.y - positionIncriment)
        },

        Queen => new DirectionsDeligate[]
        {
            (int positionIncriment) => new Coords (piece.position.x + positionIncriment, piece.position.y + positionIncriment),
            (int positionIncriment) => new Coords (piece.position.x + positionIncriment, piece.position.y - positionIncriment),
            (int positionIncriment) => new Coords(piece.position.x - positionIncriment, piece.position.y + positionIncriment),
            (int positionIncriment) => new Coords(piece.position.x - positionIncriment, piece.position.y - positionIncriment),
            (int positionIncriment) => new Coords (piece.position.x + positionIncriment, piece.position.y),
            (int positionIncriment) => new Coords (piece.position.x, piece.position.y + positionIncriment),
            (int positionIncriment) => new Coords (piece.position.x - positionIncriment, piece.position.y),
            (int positionIncriment) => new Coords(piece.position.x, piece.position.y - positionIncriment)
        },

        Knight => new DirectionsDeligate[]
        {
            (int positionIncriment) => new Coords (piece.position.x + 2, piece.position.y + 1),
            (int positionIncriment) => new Coords (piece.position.x + 2, piece.position.y - 1),
            (int positionIncriment) => new Coords (piece.position.x - 2, piece.position.y + 1),
            (int positionIncriment) => new Coords (piece.position.x - 2, piece.position.y - 1),
            (int positionIncriment) => new Coords (piece.position.x + 1, piece.position.y + 2),
            (int positionIncriment) => new Coords (piece.position.x - 1, piece.position.y + 2),
            (int positionIncriment) => new Coords (piece.position.x + 1, piece.position.y - 2),
            (int positionIncriment) => new Coords (piece.position.x - 1, piece.position.y - 2),
        },

        Pawn => new DirectionsDeligate[]
        {
            (int positionIncriment) => new Coords (piece.position.x, piece.position.y + 1),
            (int positionIncriment) => new Coords (piece.position.x, piece.position.y + 2),
            (int positionIncriment) => new Coords (piece.position.x + 1, piece.position.y + 1),
            (int positionIncriment) => new Coords(piece.position.x - 1, piece.position.y + 1)
        },

        King => new DirectionsDeligate[]
        {
            (int positionIncriment) => new Coords (piece.position.x + 1, piece.position.y + 1),
            (int positionIncriment) => new Coords (piece.position.x + 1, piece.position.y - 1),
            (int positionIncriment) => new Coords(piece.position.x - 1, piece.position.y + 1),
            (int positionIncriment) => new Coords(piece.position.x - 1, piece.position.y - 1),
            (int positionIncriment) => new Coords (piece.position.x + 1, piece.position.y),
            (int positionIncriment) => new Coords (piece.position.x, piece.position.y + 1),
            (int positionIncriment) => new Coords (piece.position.x - 1, piece.position.y),
            (int positionIncriment) => new Coords(piece.position.x, piece.position.y - 1),
            (int positionIncriment) => new Coords(piece.position.x + 2, piece.position.y),
            (int positionIncriment) => new Coords(piece.position.x - 2, piece.position.y)
        },

        _ => throw new InvalidOperationException()
    };


    public delegate Coords DirectionsDeligate(int positionIncriment);
}
