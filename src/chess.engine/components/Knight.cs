namespace chess.engine.components;

internal sealed class Knight : Piece
{
    internal Knight(PieceColour color) : base(color)
    {
    }

    internal override IEnumerable<Square> GetValidMoves(Board board)
    {
        var square = base.GetSquarePieceIsOn(board);
        var validMoves = new List<Square>();
        bool pieceIsWhite = square.Piece!.PieceIsWhite();
        char leftMove = (char)(square.Rank - 1);
        char rightMove = (char)(square.Rank + 1);
        bool canMoveLeft = leftMove >= 'a';
        bool canMoveRight = rightMove <= 'h';
        char leftMoveTwice = (char)(square.Rank - 2);
        char rightMoveTwice = (char)(square.Rank + 2);
        bool canMoveLeftTwice = leftMoveTwice >= 'a';
        bool canMoveRightTwice = rightMoveTwice <= 'h';
        int forwardMove = pieceIsWhite ? square.File + 1 : square.File - 1;
        int backwardMove = pieceIsWhite ? square.File - 1 : square.File + 1;
        bool canMoveForward = pieceIsWhite ? forwardMove <= 8 : forwardMove >= 1;
        bool canMoveBackward = pieceIsWhite ? backwardMove >= 1 : backwardMove <= 8;
        int forwardMoveTwice = pieceIsWhite ? square.File + 2 : square.File - 2;
        int backwardMoveTwice = pieceIsWhite ? square.File - 2 : square.File + 2;
        bool canMoveForwardTwice = pieceIsWhite ? forwardMoveTwice <= 8 : forwardMoveTwice >= 1;
        bool canMoveBackwardTwice = pieceIsWhite ? backwardMoveTwice >= 1 : backwardMoveTwice <= 8;

        if (canMoveForwardTwice && canMoveLeft)
        {
            AddValidMoveIfNotOccupiedBySameColour(board, validMoves, leftMove, forwardMoveTwice);
        }

        if (canMoveForwardTwice && canMoveRight)
        {
            AddValidMoveIfNotOccupiedBySameColour(board, validMoves, rightMove, forwardMoveTwice);
        }

        if (canMoveBackwardTwice && canMoveLeft)
        {
            AddValidMoveIfNotOccupiedBySameColour(board, validMoves, leftMove, backwardMoveTwice);
        }

        if (canMoveBackwardTwice && canMoveRight)
        {
            AddValidMoveIfNotOccupiedBySameColour(board, validMoves, rightMove, backwardMoveTwice);
        }

        if (canMoveLeftTwice && canMoveForward)
        {
            AddValidMoveIfNotOccupiedBySameColour(board, validMoves, leftMoveTwice, forwardMove);
        }

        if (canMoveLeftTwice && canMoveBackward)
        {
            AddValidMoveIfNotOccupiedBySameColour(board, validMoves, leftMoveTwice, backwardMove);
        }

        if (canMoveRightTwice && canMoveForward)
        {
            AddValidMoveIfNotOccupiedBySameColour(board, validMoves, rightMoveTwice, forwardMove);
        }

        if (canMoveRightTwice && canMoveBackward)
        {
            AddValidMoveIfNotOccupiedBySameColour(board, validMoves, rightMoveTwice, backwardMove);
        }

        return validMoves;
    }

    private void AddValidMoveIfNotOccupiedBySameColour(Board board, List<Square> validMoves, char rank, int file)
    {
        var square = board.GetSquare(rank, file);
        if (square.Piece?.Color != base.Color)
        {
            validMoves.Add(square);
        }
    }
}
