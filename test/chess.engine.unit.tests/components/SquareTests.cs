using chess.engine.components;

namespace chess.engine.unit.tests.components;

[TestClass]
public class SquareTests
{
    [TestMethod]
    public void Constructor_ValidInputs_InitializesPropertiesWithPiece()
    {
        char x = 'e';
        int y = 4;
        var square = new Square
        {
            positionX = x,
            positionY = y,
            Piece = new Pawn(Piece.PieceColor.White)
        };
        Assert.AreEqual(x, square.positionX, $"Failed at x={x}, y={y}");
        Assert.AreEqual(y, square.positionY, $"Failed at x={x}, y={y}");
        Assert.IsNotNull(square.Piece, $"Piece should not be null at x={x}, y={y}");
    }

    [TestMethod]
    public void Constructor_ValidInputs_InitializesPropertiesWithoutPiece()
    {
        char x = 'e';
        int y = 4;
        var square = new Square
        {
            positionX = x,
            positionY = y
        };
        Assert.AreEqual(x, square.positionX, $"Failed at x={x}, y={y}");
        Assert.AreEqual(y, square.positionY, $"Failed at x={x}, y={y}");
        Assert.IsNull(square.Piece, $"Piece should be null at x={x}, y={y}");
    }


}
