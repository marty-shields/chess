using chess.engine.components;

namespace chess.engine.unit.tests.components;

[TestClass]
public class BoardTests
{
    [TestMethod]
    public void Board_InitializesAllSquaresWithCorrectPositions()
    {
        var squares = new Board()._squares;

        for (char x = 'a'; x <= 'h'; x++)
        {
            for (int y = 1; y <= 8; y++)
            {
                var square = squares[x - 'a', y - 1];
                Assert.IsNotNull(square, $"Square at ({x},{y}) is null");
                Assert.AreEqual(x, square.positionX, $"positionX mismatch at ({x},{y})");
                Assert.AreEqual(y, square.positionY, $"positionY mismatch at ({x},{y})");
            }
        }
    }

    [TestMethod]
    public void Board_HasExactly64Squares()
    {
        var squares = new Board()._squares;

        int count = 0;
        foreach (var square in squares)
        {
            Assert.IsNotNull(square, "Square is null");
            count++;
        }
        Assert.AreEqual(64, count, "Board does not have exactly 64 squares");
    }
}