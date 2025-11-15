namespace chess.engine.components;

internal sealed class Rook : Piece
{
    internal Rook(PieceColour colour) : base(colour)
    {
    }

    internal override IEnumerable<Square> GetValidMoves(Board board)
    {
        var square = base.GetSquarePieceIsOn(board);
        var validMoves = new List<Square>();
        int moveUpFile = square.File;
        int moveDownFile = square.File;
        char moveLeftRank = square.Rank;
        char moveRightRank = square.Rank;
        bool canMoveUp = true;
        bool canMoveDown = true;
        bool canMoveLeft = true;
        bool canMoveRight = true;

        while (canMoveUp || canMoveDown || canMoveLeft || canMoveRight)
        {
            //check up
            if (canMoveUp)
            {
                moveUpFile++;
                if (CanMoveUp(moveUpFile))
                {
                    var upSquare = board.GetSquare(square.Rank, moveUpFile);
                    if (upSquare.Piece == null || upSquare.Piece.Colour != this.Colour)
                    {
                        validMoves.Add(upSquare);
                    }

                    if (upSquare.Piece != null)
                    {
                        canMoveUp = false;
                    }
                }
                else
                {
                    canMoveUp = false;
                }
            }

            //check down
            if (canMoveDown)
            {
                moveDownFile--;
                if (CanMoveDown(moveDownFile))
                {
                    var downSquare = board.GetSquare(square.Rank, moveDownFile);
                    if (downSquare.Piece == null || downSquare.Piece.Colour != this.Colour)
                    {
                        validMoves.Add(downSquare);
                    }

                    if (downSquare.Piece != null)
                    {
                        canMoveDown = false;
                    }
                }
                else
                {
                    canMoveDown = false;
                }
            }

            //check left
            if (canMoveLeft)
            {
                moveLeftRank--;
                if (CanMoveLeft(moveLeftRank))
                {
                    var leftSquare = board.GetSquare(moveLeftRank, square.File);
                    if (leftSquare.Piece == null || leftSquare.Piece.Colour != this.Colour)
                    {
                        validMoves.Add(leftSquare);
                    }

                    if (leftSquare.Piece != null)
                    {
                        canMoveLeft = false;
                    }
                }
                else
                {
                    canMoveLeft = false;
                }
            }

            //check right
            if (canMoveRight)
            {
                moveRightRank++;
                if (CanMoveRight(moveRightRank))
                {
                    var rightSquare = board.GetSquare(moveRightRank, square.File);
                    if (rightSquare.Piece == null || rightSquare.Piece.Colour != this.Colour)
                    {
                        validMoves.Add(rightSquare);
                    }
                    if (rightSquare.Piece != null)
                    {
                        canMoveRight = false;
                    }
                }
                else
                {
                    canMoveRight = false;
                }
            }
        }

        return validMoves;
    }

    private bool CanMoveUp(int file) => file <= 8;
    private bool CanMoveDown(int file) => file >= 1;
    private bool CanMoveLeft(char rank) => rank >= 'a';
    private bool CanMoveRight(char rank) => rank <= 'h';
}
