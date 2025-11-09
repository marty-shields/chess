namespace chess.engine.components;

internal abstract class Piece
{
    internal PieceColour Colour { get; private set; }

    internal Piece(PieceColour colour)
    {
        Colour = colour;
    }

    internal enum PieceColour
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
                var square = board.GetSquare(i, j);
                if (square.Piece == this)
                {
                    return square;
                }
            }
        }

        throw new InvalidOperationException($"{this.GetType().Name} is not on the board.");
    }

    internal bool PieceIsWhite() => this.Colour is PieceColour.White;
}
