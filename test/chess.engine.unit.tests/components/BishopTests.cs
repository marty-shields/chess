using chess.engine.components;

namespace chess.engine.unit.tests.components;

[TestClass]
public class BishopTests
{
    [TestMethod]
    public void GetValidMoves_BishopNotOnBoard_ThrowsException()
    {
        var board = new Board();
        var piece = new Bishop(Piece.PieceColour.White);

        var ex = Assert.ThrowsException<InvalidOperationException>(() => piece.GetValidMoves(board));
        Assert.AreEqual("Bishop is not on the board.", ex.Message);
    }

    [DataTestMethod]
    [DataRow('a', 1, new[] { "b2", "c3", "d4", "e5", "f6", "g7", "h8" })]
    [DataRow('a', 2, new[] { "b1", "b3", "c4", "d5", "e6", "f7", "g8" })]
    [DataRow('a', 3, new[] { "b2", "b4", "c1", "c5", "d6", "e7", "f8" })]
    [DataRow('a', 4, new[] { "b3", "b5", "c2", "c6", "d1", "d7", "e8" })]
    [DataRow('a', 5, new[] { "b4", "b6", "c3", "c7", "d2", "d8", "e1" })]
    [DataRow('a', 6, new[] { "b5", "b7", "c4", "c8", "d3", "e2", "f1" })]
    [DataRow('a', 7, new[] { "b6", "b8", "c5", "d4", "e3", "f2", "g1" })]
    [DataRow('a', 8, new[] { "b7", "c6", "d5", "e4", "f3", "g2", "h1" })]
    [DataRow('b', 1, new[] { "a2", "c2", "d3", "e4", "f5", "g6", "h7" })]
    [DataRow('b', 2, new[] { "a1", "a3", "c1", "c3", "d4", "e5", "f6", "g7", "h8" })]
    [DataRow('b', 3, new[] { "a2", "a4", "c2", "c4", "d1", "d5", "e6", "f7", "g8" })]
    [DataRow('b', 4, new[] { "a3", "a5", "c3", "c5", "d2", "d6", "e1", "e7", "f8" })]
    [DataRow('b', 5, new[] { "a4", "a6", "c4", "c6", "d3", "d7", "e2", "f1", "e8" })]
    [DataRow('b', 6, new[] { "a5", "a7", "c5", "c7", "d4", "d8", "e3", "f2", "g1" })]
    [DataRow('b', 7, new[] { "a6", "a8", "c6", "c8", "d5", "e4", "f3", "g2", "h1" })]
    [DataRow('b', 8, new[] { "a7", "c7", "d6", "e5", "f4", "g3", "h2" })]
    [DataRow('c', 1, new[] { "b2", "a3", "d2", "e3", "f4", "g5", "h6" })]
    [DataRow('c', 2, new[] { "b1", "b3", "a4", "d1", "d3", "e4", "f5", "g6", "h7" })]
    [DataRow('c', 3, new[] { "b2", "b4", "a1", "a5", "d2", "d4", "e1", "e5", "f6", "g7", "h8" })]
    [DataRow('c', 4, new[] { "b3", "b5", "a2", "a6", "d3", "d5", "e2", "e6", "f1", "f7", "g8" })]
    [DataRow('c', 5, new[] { "b4", "b6", "a3", "a7", "d4", "d6", "e3", "e7", "f2", "f8", "g1" })]
    [DataRow('c', 6, new[] { "b5", "b7", "a4", "a8", "d5", "d7", "e4", "e8", "f3", "g2", "h1" })]
    [DataRow('c', 7, new[] { "a5", "b6", "b8", "d6", "d8", "e5", "f4", "g3", "h2" })]
    [DataRow('c', 8, new[] { "a6", "b7", "d7", "e6", "f5", "g4", "h3" })]
    [DataRow('d', 1, new[] { "c2", "b3", "a4", "e2", "f3", "g4", "h5" })]
    [DataRow('d', 2, new[] { "c1", "c3", "b4", "a5", "e1", "e3", "f4", "g5", "h6" })]
    [DataRow('d', 3, new[] { "c2", "c4", "b1", "b5", "a6", "e2", "e4", "f1", "f5", "g6", "h7" })]
    [DataRow('d', 4, new[] { "c3", "c5", "b2", "b6", "a1", "a7", "e3", "e5", "f2", "f6", "g1", "g7", "h8" })]
    [DataRow('d', 5, new[] { "c4", "c6", "b3", "b7", "a2", "a8", "e4", "e6", "f3", "f7", "g2", "g8", "h1" })]
    [DataRow('d', 6, new[] { "c5", "c7", "b4", "b8", "a3", "e5", "e7", "f4", "f8", "g3", "h2" })]
    [DataRow('d', 7, new[] { "c6", "c8", "b5", "a4", "e6", "e8", "f5", "g4", "h3" })]
    [DataRow('d', 8, new[] { "c7", "b6", "a5", "e7", "f6", "g5", "h4" })]
    [DataRow('e', 1, new[] { "d2", "c3", "b4", "a5", "f2", "g3", "h4" })]
    [DataRow('e', 2, new[] { "d1", "d3", "c4", "b5", "a6", "f1", "f3", "g4", "h5" })]
    [DataRow('e', 3, new[] { "d2", "d4", "c1", "c5", "b6", "a7", "f2", "f4", "g1", "g5", "h6" })]
    [DataRow('e', 4, new[] { "d3", "d5", "c2", "c6", "b1", "b7", "a8", "f3", "f5", "g2", "g6", "h1", "h7" })]
    [DataRow('e', 5, new[] { "d6", "f6", "d4", "f4", "c7", "g7", "c3", "g3", "b8", "h8", "b2", "h2", "a1" })]
    [DataRow('e', 6, new[] { "d7", "f7", "d5", "f5", "c8", "g8", "c4", "g4", "b3", "h3", "a2" })]
    [DataRow('e', 7, new[] { "d6", "d8", "c5", "b4", "a3", "f6", "f8", "g5", "h4" })]
    [DataRow('e', 8, new[] { "d7", "c6", "b5", "a4", "f7", "g6", "h5" })]
    [DataRow('f', 1, new[] { "e2", "d3", "c4", "b5", "a6", "g2", "h3" })]
    [DataRow('f', 2, new[] { "e1", "e3", "d4", "c5", "b6", "a7", "g1", "g3", "h4" })]
    [DataRow('f', 3, new[] { "e2", "e4", "d1", "d5", "c6", "b7", "a8", "g2", "g4", "h1", "h5" })]
    [DataRow('f', 4, new[] { "e3", "e5", "d2", "d6", "c1", "c7", "b8", "g3", "g5", "h2", "h6" })]
    [DataRow('f', 5, new[] { "b1", "e4", "e6", "d3", "d7", "c2", "c8", "g4", "g6", "h3", "h7" })]
    [DataRow('f', 6, new[] { "e5", "e7", "d8", "d4", "g5", "g7", "h4", "h8", "c3", "b2", "a1" })]
    [DataRow('f', 7, new[] { "b3", "a2", "c4", "e6", "e8", "d5", "g6", "g8", "h5" })]
    [DataRow('f', 8, new[] { "e7", "d6", "c5", "b4", "a3", "g7", "h6" })]
    [DataRow('g', 1, new[] { "f2", "e3", "d4", "c5", "b6", "a7", "h2" })]
    [DataRow('g', 2, new[] { "f1", "f3", "e4", "d5", "c6", "b7", "a8", "h1", "h3" })]
    [DataRow('g', 3, new[] { "f4", "h4", "f2", "h2", "e5", "e1", "d6", "c7", "b8" })]
    [DataRow('g', 4, new[] { "f3", "f5", "e2", "e6", "d1", "d7", "c8", "h3", "h5" })]
    [DataRow('g', 5, new[] { "c1", "f4", "f6", "e3", "e7", "d2", "d8", "h4", "h6" })]
    [DataRow('g', 6, new[] { "f5", "f7", "e4", "e8", "h5", "h7", "d3", "c2", "b1" })]
    [DataRow('g', 7, new[] { "f8", "h8", "f6", "h6", "e5", "d4", "c3", "b2", "a1" })]
    [DataRow('g', 8, new[] { "f7", "e6", "d5", "c4", "b3", "a2", "h7" })]
    [DataRow('h', 1, new[] { "g2", "f3", "e4", "d5", "c6", "b7", "a8" })]
    [DataRow('h', 2, new[] { "g1", "g3", "f4", "e5", "d6", "c7", "b8" })]
    [DataRow('h', 3, new[] { "g2", "g4", "f1", "f5", "e6", "d7", "c8" })]
    [DataRow('h', 4, new[] { "g3", "g5", "f2", "f6", "e1", "e7", "d8" })]
    [DataRow('h', 5, new[] { "g4", "g6", "f3", "f7", "e2", "e8", "d1" })]
    [DataRow('h', 6, new[] { "g5", "g7", "f4", "f8", "e3", "d2", "c1" })]
    [DataRow('h', 7, new[] { "g6", "g8", "f5", "e4", "d3", "c2", "b1" })]
    [DataRow('h', 8, new[] { "g7", "f6", "e5", "d4", "c3", "b2", "a1" })]
    public void GetValidMoves_Bishop_AllPossiblePositions(char rank, int file, string[] expectedSquares)
    {
        var board = new Board();
        foreach (Piece.PieceColour colour in Enum.GetValues(typeof(Piece.PieceColour)))
        {
            var piece = new Bishop(colour);
            board.GetSquare(rank, file).Piece = piece;

            var possibleMoves = piece.GetValidMoves(board);

            var expectedMoves = expectedSquares.Select(sq =>
            {
                return board.GetSquare((char)sq[0], int.Parse(sq[1].ToString()));
            });

            CollectionAssert.AreEquivalent(expectedMoves.ToList(), possibleMoves.ToList(), "The valid moves for the bishop are not as expected. " +
                $"Actual: {string.Join(", ", possibleMoves.Select(sq => $"{sq.Rank}{sq.File}"))}");
        }
    }

    [DataTestMethod]
    [DataRow('a', 1, "b2", new[] { "b2" })]
    [DataRow('a', 1, "c3", new[] { "b2", "c3" })]
    [DataRow('a', 1, "d4", new[] { "b2", "c3", "d4" })]
    [DataRow('a', 1, "e5", new[] { "b2", "c3", "d4", "e5" })]
    [DataRow('a', 1, "f6", new[] { "b2", "c3", "d4", "e5", "f6" })]
    [DataRow('a', 1, "g7", new[] { "b2", "c3", "d4", "e5", "f6", "g7" })]
    [DataRow('a', 1, "h8", new[] { "b2", "c3", "d4", "e5", "f6", "g7", "h8" })]
    [DataRow('h', 1, "g2", new[] { "g2" })]
    [DataRow('h', 1, "f3", new[] { "g2", "f3" })]
    [DataRow('h', 1, "e4", new[] { "g2", "f3", "e4" })]
    [DataRow('h', 1, "d5", new[] { "g2", "f3", "e4", "d5" })]
    [DataRow('h', 1, "c6", new[] { "g2", "f3", "e4", "d5", "c6" })]
    [DataRow('h', 1, "b7", new[] { "g2", "f3", "e4", "d5", "c6", "b7" })]
    [DataRow('h', 1, "a8", new[] { "g2", "f3", "e4", "d5", "c6", "b7", "a8" })]
    [DataRow('a', 8, "b7", new[] { "b7" })]
    [DataRow('a', 8, "c6", new[] { "b7", "c6" })]
    [DataRow('a', 8, "d5", new[] { "b7", "c6", "d5" })]
    [DataRow('a', 8, "e4", new[] { "b7", "c6", "d5", "e4" })]
    [DataRow('a', 8, "f3", new[] { "b7", "c6", "d5", "e4", "f3" })]
    [DataRow('a', 8, "g2", new[] { "b7", "c6", "d5", "e4", "f3", "g2" })]
    [DataRow('a', 8, "h1", new[] { "b7", "c6", "d5", "e4", "f3", "g2", "h1" })]
    [DataRow('h', 8, "g7", new[] { "g7" })]
    [DataRow('h', 8, "f6", new[] { "g7", "f6" })]
    [DataRow('h', 8, "e5", new[] { "g7", "f6", "e5" })]
    [DataRow('h', 8, "d4", new[] { "g7", "f6", "e5", "d4" })]
    [DataRow('h', 8, "c3", new[] { "g7", "f6", "e5", "d4", "c3" })]
    [DataRow('h', 8, "b2", new[] { "g7", "f6", "e5", "d4", "c3", "b2" })]
    [DataRow('h', 8, "a1", new[] { "g7", "f6", "e5", "d4", "c3", "b2", "a1" })]
    [DataRow('d', 4, "e5", new[] { "e5", "c3", "b2", "a1", "e3", "f2", "g1", "c5", "b6", "a7" })]
    [DataRow('d', 4, "c5", new[] { "e5", "f6", "g7", "h8", "c3", "b2", "a1", "e3", "f2", "g1", "c5" })]
    [DataRow('d', 4, "c3", new[] { "e5", "f6", "g7", "h8", "c3", "e3", "f2", "g1", "c5", "b6", "a7" })]
    [DataRow('d', 4, "e3", new[] { "e5", "f6", "g7", "h8", "c3", "b2", "a1", "e3", "c5", "b6", "a7" })]

    public void GetValidMoves_Bishop_PieceCanBeCaptured_AllPossiblePositions(char rank, int file, string capturedPiece, string[] expectedSquares)
    {
        var board = new Board();
        foreach (Piece.PieceColour colour in Enum.GetValues(typeof(Piece.PieceColour)))
        {
            var piece = new Bishop(colour);
            board.GetSquare(rank, file).Piece = piece;

            var targetSquare = board.GetSquare((char)capturedPiece[0], int.Parse(capturedPiece[1].ToString()));
            targetSquare.Piece = new Pawn(colour == Piece.PieceColour.White ? Piece.PieceColour.Black : Piece.PieceColour.White);

            var possibleMoves = piece.GetValidMoves(board);

            var expectedMoves = expectedSquares.Select(sq =>
            {
                return board.GetSquare((char)sq[0], int.Parse(sq[1].ToString()));
            });

            CollectionAssert.AreEquivalent(expectedMoves.ToList(), possibleMoves.ToList(), "The valid moves for the bishop are not as expected. " +
                $"Actual: {string.Join(", ", possibleMoves.Select(sq => $"{sq.Rank}{sq.File}"))}");
        }
    }
}
