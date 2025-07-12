namespace chess.engine.components;

internal sealed class Bishop : Piece
{
    internal Bishop(PieceColour colour) : base(colour)
    {
    }

    internal override IEnumerable<Square> GetValidMoves(Board board)
    {
        var square = base.GetSquarePieceIsOn(board);
        var validMoves = new List<Square>();
        int moveUpFile = square.File, moveDownFile = square.File;
        char moveLeftRank = square.Rank, moveRightRank = square.Rank;
        bool canMoveTopLeft = true, canMoveTopRight = true, canMoveBottomLeft = true, canMoveBottomRight = true;

        // check top left diagonal
        while (canMoveTopLeft || canMoveTopRight || canMoveBottomLeft || canMoveBottomRight)
        {
            moveUpFile++;
            moveDownFile--;
            moveLeftRank--;
            moveRightRank++;

            if (canMoveTopLeft && this.CanMoveUpLeft(moveUpFile, moveLeftRank))
            {
                var topLeftSquare = board.GetSquare(moveLeftRank, moveUpFile);
                if (topLeftSquare.Piece == null || topLeftSquare.Piece.Colour != this.Colour)
                {
                    validMoves.Add(topLeftSquare);
                }

                if (topLeftSquare.Piece != null)
                {
                    canMoveTopLeft = false;
                }
            }
            else
            {
                canMoveTopLeft = false;
            }

            if (canMoveTopRight && this.CanMoveUpRight(moveUpFile, moveRightRank))
            {
                var topRightSquare = board.GetSquare(moveRightRank, moveUpFile);
                if (topRightSquare.Piece == null || topRightSquare.Piece.Colour != this.Colour)
                {
                    validMoves.Add(topRightSquare);
                }

                if (topRightSquare.Piece != null)
                {
                    canMoveTopRight = false;
                }
            }
            else
            {
                canMoveTopRight = false;
            }

            if (canMoveBottomLeft && this.CanMoveDownLeft(moveDownFile, moveLeftRank))
            {
                var bottomLeftSquare = board.GetSquare(moveLeftRank, moveDownFile);
                if (bottomLeftSquare.Piece == null || bottomLeftSquare.Piece.Colour != this.Colour)
                {
                    validMoves.Add(bottomLeftSquare);
                }

                if (bottomLeftSquare.Piece != null)
                {
                    canMoveBottomLeft = false;
                }
            }
            else
            {
                canMoveBottomLeft = false;
            }

            if (canMoveBottomRight && this.CanMoveDownRight(moveDownFile, moveRightRank))
            {
                var bottomRightSquare = board.GetSquare(moveRightRank, moveDownFile);
                if (bottomRightSquare.Piece == null || bottomRightSquare.Piece.Colour != this.Colour)
                {
                    validMoves.Add(bottomRightSquare);
                }

                if (bottomRightSquare.Piece != null)
                {
                    canMoveBottomRight = false;
                }
            }
            else
            {
                canMoveBottomRight = false;
            }
        }

        return validMoves;
    }

    private bool CanMoveUpLeft(int file, char rank) => file <= 8 && rank >= 'a';
    private bool CanMoveUpRight(int file, char rank) => file <= 8 && rank <= 'h';
    private bool CanMoveDownLeft(int file, char rank) => file >= 1 && rank >= 'a';
    private bool CanMoveDownRight(int file, char rank) => file >= 1 && rank <= 'h';
}
