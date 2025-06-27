namespace chess.engine.components;

internal class Square
{
    internal char positionX { get; init; }
    internal int positionY { get; init; }
    internal Piece? Piece { get; set; }
}
