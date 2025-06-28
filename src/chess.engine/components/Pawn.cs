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
            if (base.Color is PieceColor.White)
            {
                // move up and ensure not blocked
                if (file < 8 && !board.IsSquareOccupied(rank, file + 1))
                {
                    validMoves.Add(board.GetSquare(rank, file + 1));
                    // double move from starting position
                    if (file is 2 && !board.IsSquareOccupied(rank, file + 2))
                    {
                        validMoves.Add(board.GetSquare(rank, file + 2));
                    }
                }
                // capture left diagnonal
                char leftRank = (char)(rank - 1);
                if (rank > 'a' && file < 8 && board.CanBeCaptured(leftRank, file + 1, this))
                {
                    validMoves.Add(board.GetSquare(leftRank, file + 1));
                }
                // capture right diagnonal
                char rightRank = (char)(rank + 1);
                if (rank < 'h' && file < 8 && board.CanBeCaptured(rightRank, file + 1, this))
                {
                    validMoves.Add(board.GetSquare(rightRank, file + 1));
                }
            }
            else
            {
                // move down and ensure not blocked
                if (file > 1 && !board.IsSquareOccupied(rank, file - 1))
                {
                    validMoves.Add(board.GetSquare(rank, file - 1));
                    // double move from starting position
                    if (file is 7 && !board.IsSquareOccupied(rank, file - 2))
                    {
                        validMoves.Add(board.GetSquare(rank, file - 2));
                    }
                }
                // capture left diagnonal
                char leftRank = (char)(rank - 1);
                if (rank > 'a' && file > 1 && board.CanBeCaptured(leftRank, file - 1, this))
                {
                    validMoves.Add(board.GetSquare(leftRank, file - 1));
                }
                // capture right diagnonal
                char rightRank = (char)(rank + 1);
                if (rank < 'h' && file > 1 && board.CanBeCaptured(rightRank, file - 1, this))
                {
                    validMoves.Add(board.GetSquare(rightRank, file - 1));
                }
            }

            return validMoves;
        }
        else
        {
            throw new InvalidOperationException("Pawn is not on the board.");
        }
    }
}
