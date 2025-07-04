namespace chess.engine.components;

internal sealed class Pawn : Piece
{
    internal Pawn(PieceColor color) : base(color)
    {
    }

    internal override IEnumerable<Square> GetValidMoves(Board board)
    {
        var square = this.GetSquarePieceIsOn(board);
        List<Square> validMoves = new List<Square>();
        bool isNotOnEdgeFile = base.PieceIsWhite() ? square.File < 8 : square.File > 1;
        bool isStartPosition = base.PieceIsWhite() ? square.File is 2 : square.File is 7;
        int fileMovement = base.PieceIsWhite() ? 1 : -1;
        int doubleMovement = base.PieceIsWhite() ? 2 : -2;

        // move forward
        if (isNotOnEdgeFile && !board.IsSquareOccupied(square.Rank, square.File + fileMovement))
        {
            validMoves.Add(board.GetSquare(square.Rank, square.File + fileMovement));
            // double move from starting position
            if (isStartPosition && !board.IsSquareOccupied(square.Rank, square.File + doubleMovement))
            {
                validMoves.Add(board.GetSquare(square.Rank, square.File + doubleMovement));
            }
        }
        // capture left diagnonal
        char leftRank = (char)(square.Rank - 1);
        if (square.Rank > 'a' && isNotOnEdgeFile && board.CanBeCaptured(leftRank, square.File + fileMovement, this))
        {
            validMoves.Add(board.GetSquare(leftRank, square.File + fileMovement));
        }
        // capture right diagnonal
        char rightRank = (char)(square.Rank + 1);
        if (square.Rank < 'h' && isNotOnEdgeFile && board.CanBeCaptured(rightRank, square.File + fileMovement, this))
        {
            validMoves.Add(board.GetSquare(rightRank, square.File + fileMovement));
        }

        return validMoves;
    }
}
