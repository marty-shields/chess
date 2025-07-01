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

    internal bool PieceIsOnBoard(Board board, out char rank, out int file)
    {
        for (char i = 'a'; i <= 'h'; i++)
        {
            for (int j = 1; j <= 8; j++)
            {
                var square = board._squares[i - 'a', j - 1];
                if (square.Piece == this)
                {
                    rank = square.Rank;
                    file = square.File;
                    return true;
                }
            }
        }
        rank = char.MinValue;
        file = int.MinValue;
        return false;
    }

    internal bool PieceIsWhite() => this.Color is PieceColor.White;
}
