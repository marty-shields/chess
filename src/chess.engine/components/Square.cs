namespace chess.engine.components;

internal class Square
{
    internal char Rank { get; init; }
    internal int File { get; init; }
    internal Piece? Piece { get; set; }
}
