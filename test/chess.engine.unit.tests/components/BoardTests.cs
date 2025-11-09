using chess.engine.components;

namespace chess.engine.unit.tests.components;

[TestClass]
public class BoardTests
{
    [TestMethod]
    public void Board_InitializesAllSquaresWithCorrectPositions()
    {
        var board = new Board();

        for (char x = 'a'; x <= 'h'; x++)
        {
            for (int y = 1; y <= 8; y++)
            {
                var square = board.GetSquare(x, y);
                Assert.IsNotNull(square, $"Square at ({x},{y}) is null");
                Assert.AreEqual(x, square.Rank, $"positionX mismatch at ({x},{y})");
                Assert.AreEqual(y, square.File, $"positionY mismatch at ({x},{y})");
            }
        }
    }

    [TestMethod]
    public void Board_GenerateStartingPositionsForPawns_SetsCorrectSquares()
    {
        var board = new Board();
        board.GenerateStartingPositionsForPawns();

        for (char x = 'a'; x <= 'h'; x++)
        {
            var whitePawn = board.GetSquare(x, 2).Piece;
            Assert.IsNotNull(whitePawn, $"White pawn should be at {x}2");
            Assert.IsInstanceOfType(whitePawn, typeof(Pawn), $"Square {x}2 should contain a Pawn");
            Assert.AreEqual(Piece.PieceColour.White, ((Pawn)whitePawn).Colour, $"Pawn at {x}2 should be White");

            var blackPawn = board.GetSquare(x, 7).Piece;
            Assert.IsNotNull(blackPawn, $"Black pawn should be at {x}7");
            Assert.IsInstanceOfType(blackPawn, typeof(Pawn), $"Square {x}7 should contain a Pawn");
            Assert.AreEqual(Piece.PieceColour.Black, ((Pawn)blackPawn).Colour, $"Pawn at {x}7 should be Black");
        }

        //test that other squares do not have any other pieces
        for (char x = 'a'; x <= 'h'; x++)
        {
            for (int y = 1; y <= 8; y++)
            {
                if (y == 2 || y == 7) continue; // Skip ranks with pawns
                var square = board.GetSquare(x, y);
                Assert.IsNull(square.Piece, $"Square {x}{y} should not have any pieces");
            }
        }
    }

    [TestMethod]
    public void Board_GenerateStartingPositionsForBishops_SetsCorrectSquares()
    {
        var board = new Board();
        board.GenerateStartingPositionsForBishops();

        var bishop = board.GetSquare('c', 1).Piece;
        Assert.IsNotNull(bishop, "White bishop should be at c1");
        Assert.IsInstanceOfType(bishop, typeof(Bishop), "Square c1 should contain a Bishop");
        Assert.AreEqual(Piece.PieceColour.White, ((Bishop)bishop).Colour, "Bishop at c1 should be White");

        bishop = board.GetSquare('f', 1).Piece;
        Assert.IsNotNull(bishop, "White bishop should be at f1");
        Assert.IsInstanceOfType(bishop, typeof(Bishop), "Square f1 should contain a Bishop");
        Assert.AreEqual(Piece.PieceColour.White, ((Bishop)bishop).Colour, "Bishop at f1 should be White");

        bishop = board.GetSquare('c', 8).Piece;
        Assert.IsNotNull(bishop, "Black bishop should be at c8");
        Assert.IsInstanceOfType(bishop, typeof(Bishop), "Square c8 should contain a Bishop");
        Assert.AreEqual(Piece.PieceColour.Black, ((Bishop)bishop).Colour, "Bishop at c8 should be Black");

        bishop = board.GetSquare('f', 8).Piece;
        Assert.IsNotNull(bishop, "Black bishop should be at f8");
        Assert.IsInstanceOfType(bishop, typeof(Bishop), "Square f8 should contain a Bishop");
        Assert.AreEqual(Piece.PieceColour.Black, ((Bishop)bishop).Colour, "Bishop at f8 should be Black");
    }

    [TestMethod]
    public void Board_GenerateStartingPositionsForKnights_SetsCorrectSquares()
    {
        var board = new Board();
        board.GenerateStartingPositionsForKnights();

        var knight = board.GetSquare('b', 1).Piece;
        Assert.IsNotNull(knight, "White knight should be at b1");
        Assert.IsInstanceOfType(knight, typeof(Knight), "Square b1 should contain a Knight");
        Assert.AreEqual(Piece.PieceColour.White, ((Knight)knight).Colour, "Knight at b1 should be White");

        knight = board.GetSquare('g', 1).Piece;
        Assert.IsNotNull(knight, "White knight should be at g1");
        Assert.IsInstanceOfType(knight, typeof(Knight), "Square g1 should contain a Knight");
        Assert.AreEqual(Piece.PieceColour.White, ((Knight)knight).Colour, "Knight at g1 should be White");

        knight = board.GetSquare('b', 8).Piece;
        Assert.IsNotNull(knight, "Black knight should be at b8");
        Assert.IsInstanceOfType(knight, typeof(Knight), "Square b8 should contain a Knight");
        Assert.AreEqual(Piece.PieceColour.Black, ((Knight)knight).Colour, "Knight at b8 should be Black");

        knight = board.GetSquare('g', 8).Piece;
        Assert.IsNotNull(knight, "Black knight should be at g8");
        Assert.IsInstanceOfType(knight, typeof(Knight), "Square g8 should contain a Knight");
        Assert.AreEqual(Piece.PieceColour.Black, ((Knight)knight).Colour, "Knight at g8 should be Black");
    }

    [TestMethod]
    public void IsSquareOccupied_ReturnsFalse_WhenSquareIsEmpty()
    {
        var board = new Board();
        Assert.IsFalse(board.IsSquareOccupied('a', 1));
    }

    [TestMethod]
    public void IsSquareOccupied_ReturnsTrue_WhenSquareIsOccupied()
    {
        var board = new Board();
        board.GenerateStartingPositionsForPawns();
        Assert.IsTrue(board.IsSquareOccupied('a', 2)); // White pawn
        Assert.IsTrue(board.IsSquareOccupied('a', 7)); // Black pawn
    }

    [DataTestMethod]
    [DataRow('a', 0)]
    [DataRow('a', -1)]
    [DataRow('h', 0)]
    [DataRow('a', 9)]
    [DataRow('h', 9)]
    public void IsSquareOccupied_ThrowsArgumentOutOfRangeException_WhenCoordinatesAreOutOfBounds(char x, int y)
    {
        var board = new Board();
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => board.IsSquareOccupied(x, y));
    }

    [TestMethod]
    public void IsSquareOccupied_ReturnsFalse_WhenSquareIsCleared()
    {
        var board = new Board();
        board.GenerateStartingPositionsForPawns();
        board.GetSquare('a', 2).Piece = null;
        Assert.IsFalse(board.IsSquareOccupied('a', 2));
    }

    [TestMethod]
    public void CanBeCaptured_ReturnsFalse_WhenSquareIsEmpty()
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColour.White);
        Assert.IsFalse(board.CanBeCaptured('a', 1, piece));
    }

    [TestMethod]
    public void CanBeCaptured_ReturnsFalse_WhenPieceIsSameColour()
    {
        var board = new Board();
        var whitePiece = new Pawn(Piece.PieceColour.White);
        var blackPiece = new Pawn(Piece.PieceColour.Black);

        board.GetSquare('a', 2).Piece = whitePiece;
        board.GetSquare('a', 7).Piece = blackPiece;

        Assert.IsFalse(board.CanBeCaptured('a', 2, whitePiece));
        Assert.IsFalse(board.CanBeCaptured('a', 7, blackPiece));
    }

    [TestMethod]
    public void CanBeCaptured_ReturnsTrue_WhenPieceIsOppositeColour()
    {
        var board = new Board();
        var whitePiece = new Pawn(Piece.PieceColour.White);
        var blackPiece = new Pawn(Piece.PieceColour.Black);

        board.GetSquare('a', 2).Piece = blackPiece;
        board.GetSquare('a', 7).Piece = whitePiece;
        
        Assert.IsTrue(board.CanBeCaptured('a', 2, whitePiece));
        Assert.IsTrue(board.CanBeCaptured('a', 7, blackPiece));
    }

    [DataTestMethod]
    [DataRow('a', 0)]
    [DataRow('a', -1)]
    [DataRow('h', 0)]
    [DataRow('a', 9)]
    [DataRow('h', 9)]
    public void CanBeCaptured_ThrowsArgumentOutOfRangeException_WhenCoordinatesAreOutOfBounds(char x, int y)
    {
        var board = new Board();
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => board.CanBeCaptured(x, y, new Pawn(Piece.PieceColour.White)));
    }
}