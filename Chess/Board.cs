using Chess.Pieces;

namespace Chess;


public sealed class Board : IDisposable
{
    Dictionary<Coords, Piece> chessBoard = new Dictionary<Coords, Piece>();

    public void AddPiece (Coords coordinate, Piece piece)
    {
        if (chessBoard.ContainsKey(coordinate) is false)
        {
            chessBoard.Add(coordinate, piece);
        }
    }
    
    public void RemovePiece(Coords coordinate)
    {
        chessBoard.Remove(coordinate);
    }

    public Dictionary<Coords, Piece> GetPieceLocations()
    {
        return chessBoard;
    }
    
    public void Dispose()
    {
        GC.Collect();
    }
}
