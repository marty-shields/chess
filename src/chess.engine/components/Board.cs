namespace chess.engine.components;

internal sealed class Board
{
    private const int BoardSizeRank = 8;
    private const int BoardSizeFile = 8;
    private const int BoardStart = 0;
    private const char RankStart = 'a';
    private const char RankEnd = 'h';
    private const int FileStart = 1;
    private const int FileEnd = 8;

    internal readonly Square[,] _squares;

    internal Board()
    {
        _squares = new Square[BoardSizeRank, BoardSizeFile];
        for (char x = RankStart; x <= RankEnd; x++)
        {
            for (int y = BoardStart; y < BoardSizeFile; y++)
            {
                _squares[x - RankStart, y] = new Square
                {
                    Rank = x,
                    File = y + 1
                };
            }
        }
    }

    internal void GenerateStartingPositionsForPawns()
    {
        for (char x = RankStart; x <= RankEnd; x++)
        {
            _squares[x - RankStart, 1].Piece = new Pawn(Piece.PieceColour.White);
            _squares[x - RankStart, 6].Piece = new Pawn(Piece.PieceColour.Black);
        }
    }

    internal bool IsSquareOccupied(char rank, int file)
    {
        var square = this.GetSquare(rank, file);
        return square.Piece is not null;
    }

    internal bool CanBeCaptured(char rank, int file, Piece currentPiece)
    {
        var square = this.GetSquare(rank, file);
        return square.Piece is not null && square.Piece.Colour != currentPiece.Colour;
    }

    internal Square GetSquare(char rank, int file)
    {
        if (rank < RankStart || rank > RankEnd || file < FileStart || file > FileEnd)
        {
            throw new ArgumentOutOfRangeException("Coordinates are out of bounds.");
        }

        return _squares[rank - RankStart, file - FileStart];
    }
}
