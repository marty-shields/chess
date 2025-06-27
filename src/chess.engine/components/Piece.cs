namespace chess.engine.components;

public abstract class Piece
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

    internal abstract IEnumerable<(int, int)> GetValidMoves(Board board);

    internal bool PieceIsOnBoard(Board board, out int x, out int y)
    {
        for (char i = 'a'; i <= 'h'; i++)
        {
            for (int j = 1; j <= 8; j++)
            {
                var square = board._squares[i - 'a', j - 1];
                if (square.Piece == this)
                {
                    x = i - 'a';
                    y = j - 1;
                    return true;
                }
            }
        }
        x = -1;
        y = -1;
        return false;
    }
}
