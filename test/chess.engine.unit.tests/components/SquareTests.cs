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
            Rank = x,
            File = y,
            Piece = new Pawn(Piece.PieceColor.White)
        };
        Assert.AreEqual(x, square.Rank, $"Failed at x={x}, y={y}");
        Assert.AreEqual(y, square.File, $"Failed at x={x}, y={y}");
        Assert.IsNotNull(square.Piece, $"Piece should not be null at x={x}, y={y}");
    }

    [TestMethod]
    public void Constructor_ValidInputs_InitializesPropertiesWithoutPiece()
    {
        char x = 'e';
        int y = 4;
        var square = new Square
        {
            Rank = x,
            File = y
        };
        Assert.AreEqual(x, square.Rank, $"Failed at x={x}, y={y}");
        Assert.AreEqual(y, square.File, $"Failed at x={x}, y={y}");
        Assert.IsNull(square.Piece, $"Piece should be null at x={x}, y={y}");
    }


}
