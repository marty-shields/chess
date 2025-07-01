namespace chess.engine.components;

internal sealed class Pawn : Piece
{
    internal Pawn(PieceColor color) : base(color)
    {
    }

    internal override IEnumerable<Square> GetValidMoves(Board board)
    {
        if (base.PieceIsOnBoard(board, out char rank, out int file))
        {
            List<Square> validMoves = new List<Square>();
            bool isNotOnEdgeFile = base.PieceIsWhite() ? file < 8 : file > 1;
            bool isStartPosition = base.PieceIsWhite() ? file is 2 : file is 7;
            int fileMovement = base.PieceIsWhite() ? 1 : -1;
            int doubleMovement = base.PieceIsWhite() ? 2 : -2;

            // move forward
            if (isNotOnEdgeFile && !board.IsSquareOccupied(rank, file + fileMovement))
            {
                validMoves.Add(board.GetSquare(rank, file + fileMovement));
                // double move from starting position
                if (isStartPosition && !board.IsSquareOccupied(rank, file + doubleMovement))
                {
                    validMoves.Add(board.GetSquare(rank, file + doubleMovement));
                }
            }
            // capture left diagnonal
            char leftRank = (char)(rank - 1);
            if (rank > 'a' && isNotOnEdgeFile && board.CanBeCaptured(leftRank, file + fileMovement, this))
            {
                validMoves.Add(board.GetSquare(leftRank, file + fileMovement));
            }
            // capture right diagnonal
            char rightRank = (char)(rank + 1);
            if (rank < 'h' && isNotOnEdgeFile && board.CanBeCaptured(rightRank, file + fileMovement, this))
            {
                validMoves.Add(board.GetSquare(rightRank, file + fileMovement));
            }

            return validMoves;
        }
        else
        {
            throw new InvalidOperationException("Pawn is not on the board.");
        }
    }
}
