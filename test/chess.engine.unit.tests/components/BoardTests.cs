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

    [TestMethod]
    public void Board_GenerateStartingPositionsForPawns_SetsCorrectSquares()
    {
        var board = new Board();
        board.GenerateStartingPositionsForPawns();

        for (char x = 'a'; x <= 'h'; x++)
        {
            // White pawns at rank 2 (index 1)
            var whitePawn = board._squares[x - 'a', 1].Piece;
            Assert.IsNotNull(whitePawn, $"White pawn should be at {x}2");
            Assert.IsInstanceOfType(whitePawn, typeof(Pawn), $"Square {x}2 should contain a Pawn");
            Assert.AreEqual(Piece.PieceColor.White, ((Pawn)whitePawn).Color, $"Pawn at {x}2 should be White");

            // Black pawns at rank 7 (index 6)
            var blackPawn = board._squares[x - 'a', 6].Piece;
            Assert.IsNotNull(blackPawn, $"Black pawn should be at {x}7");
            Assert.IsInstanceOfType(blackPawn, typeof(Pawn), $"Square {x}7 should contain a Pawn");
            Assert.AreEqual(Piece.PieceColor.Black, ((Pawn)blackPawn).Color, $"Pawn at {x}7 should be Black");
        }

        //test that other squares do not have any other pieces
        for (char x = 'a'; x <= 'h'; x++)
        {
            for (int y = 1; y <= 8; y++)
            {
                if (y == 2 || y == 7) continue; // Skip ranks with pawns
                var square = board._squares[x - 'a', y - 1];
                Assert.IsNull(square.Piece, $"Square {x}{y} should not have any pieces");
            }
        }
    }

    [TestMethod]
    public void IsSquareOccupied_ReturnsFalse_WhenSquareIsEmpty()
    {
        var board = new Board();
        // Square at (0,0) should be empty initially
        Assert.IsFalse(board.IsSquareOccupied(0, 0));
    }

    [TestMethod]
    public void IsSquareOccupied_ReturnsTrue_WhenSquareIsOccupied()
    {
        var board = new Board();
        // Place a pawn at (0,1)
        board.GenerateStartingPositionsForPawns();
        Assert.IsTrue(board.IsSquareOccupied(0, 1)); // White pawn
        Assert.IsTrue(board.IsSquareOccupied(0, 6)); // Black pawn
    }

    [DataTestMethod]
    [DataRow(-1, 0)]
    [DataRow(0, -1)]
    [DataRow(8, 0)]
    [DataRow(0, 8)]
    [DataRow(8, 8)]
    public void IsSquareOccupied_ThrowsArgumentOutOfRangeException_WhenCoordinatesAreOutOfBounds(int x, int y)
    {
        var board = new Board();
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => board.IsSquareOccupied(x, y));
    }

    [TestMethod]
    public void IsSquareOccupied_ReturnsFalse_WhenSquareIsCleared()
    {
        var board = new Board();
        board.GenerateStartingPositionsForPawns();
        // Remove pawn from (0,1)
        board._squares[0, 1].Piece = null;
        Assert.IsFalse(board.IsSquareOccupied(0, 1));
    }

    [TestMethod]
    public void CanBeCaptured_ReturnsFalse_WhenSquareIsEmpty()
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.White);
        Assert.IsFalse(board.CanBeCaptured(0, 0, piece));
    }

    [TestMethod]
    public void CanBeCaptured_ReturnsFalse_WhenPieceIsSameColor()
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.White);
        var whitePiece = new Pawn(Piece.PieceColor.White);
        board._squares[0, 1] = new Square();
        board._squares[0, 1].Piece = whitePiece;
        // White pawn at (0,1)
        Assert.IsFalse(board.CanBeCaptured(0, 1, piece));

        var blackPiece = new Pawn(Piece.PieceColor.Black);
        board._squares[0, 6] = new Square();
        board._squares[0, 6].Piece = blackPiece;
        piece = new Pawn(Piece.PieceColor.Black);
        // Black pawn at (0,6)
        Assert.IsFalse(board.CanBeCaptured(0, 6, piece));
    }

    [TestMethod]
    public void CanBeCaptured_ReturnsTrue_WhenPieceIsOppositeColor()
    {
        var board = new Board();
        board._squares[0, 1] = new Square();
        board._squares[0, 1].Piece = new Pawn(Piece.PieceColor.White);
        board._squares[0, 6] = new Square();
        board._squares[0, 6].Piece = new Pawn(Piece.PieceColor.Black);
        var piece = new Pawn(Piece.PieceColor.Black);
        // White pawn at (0,1)
        Assert.IsTrue(board.CanBeCaptured(0, 1, piece));

        // Black pawn at (0,6)
        piece = new Pawn(Piece.PieceColor.White);
        Assert.IsTrue(board.CanBeCaptured(0, 6, piece));
    }

    [DataTestMethod]
    [DataRow(-1, 0)]
    [DataRow(0, -1)]
    [DataRow(8, 0)]
    [DataRow(0, 8)]
    [DataRow(8, 8)]
    public void CanBeCaptured_ThrowsArgumentOutOfRangeException_WhenCoordinatesAreOutOfBounds(int x, int y)
    {
        var board = new Board();
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => board.CanBeCaptured(x, y, new Pawn(Piece.PieceColor.White)));
    }
}