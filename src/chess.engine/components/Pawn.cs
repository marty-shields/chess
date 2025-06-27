namespace chess.engine.components;

internal class Pawn : Piece
{
    internal Pawn(PieceColor color) : base(color)
    {
    }

    internal override IEnumerable<(int, int)> GetValidMoves(Board board)
    {
        if (base.PieceIsOnBoard(board, out int x, out int y))
        {
            List<(int, int)> validMoves = new List<(int, int)>();
            if (base.Color is PieceColor.White)
            {
                // move up and ensure not blocked
                if (y < 7 && !board.IsSquareOccupied(x, y + 1))
                {
                    validMoves.Add((x, y + 1));
                    // double move from starting position
                    if (y is 1 && !board.IsSquareOccupied(x, y + 2))
                    {
                        validMoves.Add((x, y + 2));
                    }
                }
                // capture left diagnonal
                if (x > 0 && y < 7 && board.CanBeCaptured(x - 1, y + 1, this))
                {
                    validMoves.Add((x - 1, y + 1));
                }
                // capture right diagnonal
                if (x < 7 && y < 7 && board.CanBeCaptured(x + 1, y + 1, this))
                {
                    validMoves.Add((x + 1, y + 1));
                }
            }
            else
            {
                // move down and ensure not blocked
                if (y > 0 && !board.IsSquareOccupied(x, y - 1))
                {
                    validMoves.Add((x, y - 1));
                    // double move from starting position
                    if (y is 6 && !board.IsSquareOccupied(x, y - 2))
                    {
                        validMoves.Add((x, y - 2));
                    }
                }
                // capture left diagnonal
                if (x > 0 && y > 0 && board.CanBeCaptured(x - 1, y - 1, this))
                {
                    validMoves.Add((x - 1, y - 1));
                }
                // capture right diagnonal
                if (x < 7 && y > 0 && board.CanBeCaptured(x + 1, y - 1, this))
                {
                    validMoves.Add((x + 1, y - 1));
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
