namespace chess.engine.components;

public sealed class Board
{
    private const int BoardSizeX = 8;
    private const int BoardSizeY = 8;
    private const int BoardStart = 0;
    private const char RowStart = 'a';
    private const char RowEnd = 'h';
    internal readonly Square[,] _squares;

    public Board()
    {
        _squares = new Square[BoardSizeX, BoardSizeY];
        for (char x = RowStart; x <= RowEnd; x++)
        {
            for (int y = BoardStart + 1; y <= BoardSizeY; y++)
            {
                _squares[x - RowStart, y - BoardStart - 1] = new Square
                {
                    positionX = x,
                    positionY = y
                };
            }
        }
    }

    public void GenerateStartingPositionsForPawns()
    {
        for (char x = 'a'; x <= 'h'; x++)
        {
            _squares[x - 'a', 1].Piece = new Pawn(Piece.PieceColor.White);
            _squares[x - 'a', 6].Piece = new Pawn(Piece.PieceColor.Black);
        }
    }

    public bool IsSquareOccupied(int x, int y)
    {
        if (x < BoardStart || x >= BoardSizeX || y < BoardStart || y >= BoardSizeY)
        {
            throw new ArgumentOutOfRangeException("Coordinates are out of bounds.");
        }

        return _squares[x, y].Piece is not null;
    }

    public bool CanBeCaptured(int x, int y, Piece currentPiece)
    {
        if (x < BoardStart || x >= BoardSizeX || y < BoardStart || y >= BoardSizeY)
        {
            throw new ArgumentOutOfRangeException("Coordinates are out of bounds.");
        }

        var square = _squares[x, y];
        return square.Piece is not null && square.Piece.Color != currentPiece.Color;
    }
}
