namespace chess.engine.components;

public sealed class Board
{
    internal readonly Square[,] _squares;

    public Board()
    {
        _squares = new Square[8, 8];
        for (char x = 'a'; x <= 'h'; x++)
        {
            for (int y = 1; y <= 8; y++)
            {
                _squares[x - 'a', y - 1] = new Square
                {
                    positionX = x,
                    positionY = y
                };
            }
        }
    }
}
