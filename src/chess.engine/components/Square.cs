namespace chess.engine.components;

public sealed class Square
{
    public Square(char positionX, int positionY)
    {
        if (!IsPosValid(positionX))
        {
            throw new ArgumentOutOfRangeException(nameof(positionX));
        }
        if (!IsPosValid(positionY))
        {
            throw new ArgumentOutOfRangeException(nameof(positionY));
        }
        this.positionX = positionX;
        this.positionY = positionY;
    }

    public char positionX { get; private set; }
    public int positionY { get; private set; }

    private bool IsPosValid(char positionX) => positionX is >= 'a' and <= 'h';
    private bool IsPosValid(int positionY) => positionY is >= 1 and <= 8;
}
