using chess.engine.components;

namespace chess.engine.unit.tests.components;

[TestClass]
public class SquareTests
{
    [TestMethod]
    public void Constructor_ValidInputs_InitializesProperties()
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
    }
}
