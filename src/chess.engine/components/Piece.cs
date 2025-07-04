namespace chess.engine.components;

internal abstract class Piece
{
    internal PieceColor Color { get; private set; }

    internal Piece(PieceColor color)
    {
        Color = color;
    }

    internal enum PieceColor
    {
        White,
        Black
    }

    internal abstract IEnumerable<Square> GetValidMoves(Board board);

    protected Square GetSquarePieceIsOn(Board board)
    {
        for (char i = 'a'; i <= 'h'; i++)
        {
            for (int j = 1; j <= 8; j++)
            {
                var square = board._squares[i - 'a', j - 1];
                if (square.Piece == this)
                {
                    return square;
                }
            }
        }

        throw new InvalidOperationException($"{this.GetType().Name} is not on the board.");
    }

    internal bool PieceIsWhite() => this.Color is PieceColor.White;
}
