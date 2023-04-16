using Chess.Pieces;

namespace Chess
{
    public static class MoveValidator
    {

        public static List<Coords> GetLegalMoves(Board chessBoard, Piece piece)
        {
            List<Coords> potentialMoveList = new List<Coords>();

            foreach (DirectionsDeligate directionsDeligate in GetPieceMovesDeletage(piece))
            {
                for (int positionIncriment = 1; positionIncriment < 8; positionIncriment++)
                {
                    Coords potentialMove = directionsDeligate(positionIncriment);

                    if (CoordsContainsNonTakablePiece(chessBoard, piece, potentialMove))
                    {
                        break;
                    }

                    if (CoordsContainsTakablePiece(chessBoard, piece, potentialMove))
                    {
                        potentialMoveList.Add(potentialMove);
                        break;
                    }

                    if (0 <= potentialMove.x && potentialMove.x <= 7 && 0 <= potentialMove.y && potentialMove.y <= 7)
                    {
                        potentialMoveList.Add(potentialMove);
                    }
                }
            }

            return potentialMoveList;
        }


        private static bool CoordsContainsNonTakablePiece(Board board, Piece piece, Coords coord) => board.GetPieceLocations().Where(x => x.Value.colour != piece.colour && x.Value is King || x.Value.colour == piece.colour).ToDictionary(x => x.Key).Keys.Contains(coord);

        private static bool CoordsContainsTakablePiece(Board board, Piece piece, Coords coord) => board.GetPieceLocations().Where(x => x.Value.colour != piece.colour && x.Value is not King).ToDictionary(x => x.Key).Keys.Contains(coord);

        private static bool MovingPiecePutsOwnsKingIntoCheck(Piece piece, Board board) => false;

        private static bool OpponentsLastMoveAllowsEnPassant() => false;
    }
}