using chess.engine.components;

namespace chess.engine.unit.tests.components;

[TestClass]
public class SquareTests
{
    [TestMethod]
    public void Constructor_ValidInputs_InitializesProperties()
    {
        // Test all 64 valid squares: x in 'a'-'h', y in 1-8
        for (char x = 'a'; x <= 'h'; x++)
        {
            for (int y = 1; y <= 8; y++)
            {
                var square = new Square(x, y);
                Assert.AreEqual(x, square.positionX, $"Failed at x={x}, y={y}");
                Assert.AreEqual(y, square.positionY, $"Failed at x={x}, y={y}");
            }
        }
    }

    [TestMethod]
    [DataRow((char)('a' - 1), 1)] // x below lower bound
    [DataRow((char)('h' + 1), 1)] // x above upper bound
    [DataRow('a', 0)]             // y below lower bound
    [DataRow('a', 9)]             // y above upper bound
    [DataRow((char)('a' - 1), 0)] // both below lower bound
    [DataRow((char)('h' + 1), 9)] // both above upper bound
    [DataTestMethod]
    public void Constructor_InvalidInputs_ThrowsException(char x, int y)
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Square(x, y), $"Failed at x={x}, y={y}");
    }
}
