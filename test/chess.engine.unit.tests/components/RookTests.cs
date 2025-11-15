using chess.engine.components;

namespace chess.engine.unit.tests.components;

[TestClass]
public class RookTests
{
    [TestMethod]
    public void GetValidMoves_RookNotOnBoard_ThrowsException()
    {
        var board = new Board();
        var piece = new Rook(Piece.PieceColour.White);

        var ex = Assert.ThrowsException<InvalidOperationException>(() => piece.GetValidMoves(board));
        Assert.AreEqual("Rook is not on the board.", ex.Message);
    }

    [DataTestMethod]
    [DataRow('a', 1, new[] { "a2", "a3", "a4", "a5", "a6", "a7", "a8", "b1", "c1", "d1", "e1", "f1", "g1", "h1" })]
    [DataRow('a', 2, new[] { "a1", "a3", "a4", "a5", "a6", "a7", "a8", "b2", "c2", "d2", "e2", "f2", "g2", "h2" })]
    [DataRow('a', 3, new[] { "a1", "a2", "a4", "a5", "a6", "a7", "a8", "b3", "c3", "d3", "e3", "f3", "g3", "h3" })]
    [DataRow('a', 4, new[] { "a1", "a2", "a3", "a5", "a6", "a7", "a8", "b4", "c4", "d4", "e4", "f4", "g4", "h4" })]
    [DataRow('a', 5, new[] { "a1", "a2", "a3", "a4", "a6", "a7", "a8", "b5", "c5", "d5", "e5", "f5", "g5", "h5" })]
    [DataRow('a', 6, new[] { "a1", "a2", "a3", "a4", "a5", "a7", "a8", "b6", "c6", "d6", "e6", "f6", "g6", "h6" })]
    [DataRow('a', 7, new[] { "a1", "a2", "a3", "a4", "a5", "a6", "a8", "b7", "c7", "d7", "e7", "f7", "g7", "h7" })]
    [DataRow('a', 8, new[] { "a1", "a2", "a3", "a4", "a5", "a6", "a7", "b8", "c8", "d8", "e8", "f8", "g8", "h8" })]
    [DataRow('b', 1, new[] { "a1", "c1", "d1", "e1", "f1", "g1", "h1", "b2", "b3", "b4", "b5", "b6", "b7", "b8" })]
    [DataRow('b', 2, new[] { "a2", "c2", "d2", "e2", "f2", "g2", "h2", "b1", "b3", "b4", "b5", "b6", "b7", "b8" })]
    [DataRow('b', 3, new[] { "a3", "c3", "d3", "e3", "f3", "g3", "h3", "b1", "b2", "b4", "b5", "b6", "b7", "b8" })]
    [DataRow('b', 4, new[] { "a4", "c4", "d4", "e4", "f4", "g4", "h4", "b1", "b2", "b3", "b5", "b6", "b7", "b8" })]
    [DataRow('b', 5, new[] { "a5", "c5", "d5", "e5", "f5", "g5", "h5", "b1", "b2", "b3", "b4", "b6", "b7", "b8" })]
    [DataRow('b', 6, new[] { "a6", "c6", "d6", "e6", "f6", "g6", "h6", "b1", "b2", "b3", "b4", "b5", "b7", "b8" })]
    [DataRow('b', 7, new[] { "a7", "c7", "d7", "e7", "f7", "g7", "h7", "b1", "b2", "b3", "b4", "b5", "b6", "b8" })]
    [DataRow('b', 8, new[] { "a8", "c8", "d8", "e8", "f8", "g8", "h8", "b1", "b2", "b3", "b4", "b5", "b6", "b7" })]
    [DataRow('c', 1, new[] { "a1", "b1", "d1", "e1", "f1", "g1", "h1", "c2", "c3", "c4", "c5", "c6", "c7", "c8" })]
    [DataRow('c', 2, new[] { "a2", "b2", "d2", "e2", "f2", "g2", "h2", "c1", "c3", "c4", "c5", "c6", "c7", "c8" })]
    [DataRow('c', 3, new[] { "a3", "b3", "d3", "e3", "f3", "g3", "h3", "c1", "c2", "c4", "c5", "c6", "c7", "c8" })]
    [DataRow('c', 4, new[] { "a4", "b4", "d4", "e4", "f4", "g4", "h4", "c1", "c2", "c3", "c5", "c6", "c7", "c8" })]
    [DataRow('c', 5, new[] { "a5", "b5", "d5", "e5", "f5", "g5", "h5", "c1", "c2", "c3", "c4", "c6", "c7", "c8" })]
    [DataRow('c', 6, new[] { "a6", "b6", "d6", "e6", "f6", "g6", "h6", "c1", "c2", "c3", "c4", "c5", "c7", "c8" })]
    [DataRow('c', 7, new[] { "a7", "b7", "d7", "e7", "f7", "g7", "h7", "c1", "c2", "c3", "c4", "c5", "c6", "c8" })]
    [DataRow('c', 8, new[] { "a8", "b8", "d8", "e8", "f8", "g8", "h8", "c1", "c2", "c3", "c4", "c5", "c6", "c7" })]
    [DataRow('d', 1, new[] { "a1", "b1", "c1", "e1", "f1", "g1", "h1", "d2", "d3", "d4", "d5", "d6", "d7", "d8" })]
    [DataRow('d', 2, new[] { "a2", "b2", "c2", "e2", "f2", "g2", "h2", "d1", "d3", "d4", "d5", "d6", "d7", "d8" })]
    [DataRow('d', 3, new[] { "a3", "b3", "c3", "e3", "f3", "g3", "h3", "d1", "d2", "d4", "d5", "d6", "d7", "d8" })]
    [DataRow('d', 4, new[] { "a4", "b4", "c4", "e4", "f4", "g4", "h4", "d1", "d2", "d3", "d5", "d6", "d7", "d8" })]
    [DataRow('d', 5, new[] { "a5", "b5", "c5", "e5", "f5", "g5", "h5", "d1", "d2", "d3", "d4", "d6", "d7", "d8" })]
    [DataRow('d', 6, new[] { "a6", "b6", "c6", "e6", "f6", "g6", "h6", "d1", "d2", "d3", "d4", "d5", "d7", "d8" })]
    [DataRow('d', 7, new[] { "a7", "b7", "c7", "e7", "f7", "g7", "h7", "d1", "d2", "d3", "d4", "d5", "d6", "d8" })]
    [DataRow('d', 8, new[] { "a8", "b8", "c8", "e8", "f8", "g8", "h8", "d1", "d2", "d3", "d4", "d5", "d6", "d7" })]
    [DataRow('e', 1, new[] { "a1", "b1", "c1", "d1", "f1", "g1", "h1", "e2", "e3", "e4", "e5", "e6", "e7", "e8" })]
    [DataRow('e', 2, new[] { "a2", "b2", "c2", "d2", "f2", "g2", "h2", "e1", "e3", "e4", "e5", "e6", "e7", "e8" })]
    [DataRow('e', 3, new[] { "a3", "b3", "c3", "d3", "f3", "g3", "h3", "e1", "e2", "e4", "e5", "e6", "e7", "e8" })]
    [DataRow('e', 4, new[] { "a4", "b4", "c4", "d4", "f4", "g4", "h4", "e1", "e2", "e3", "e5", "e6", "e7", "e8" })]
    [DataRow('e', 5, new[] { "a5", "b5", "c5", "d5", "f5", "g5", "h5", "e1", "e2", "e3", "e4", "e6", "e7", "e8" })]
    [DataRow('e', 6, new[] { "a6", "b6", "c6", "d6", "f6", "g6", "h6", "e1", "e2", "e3", "e4", "e5", "e7", "e8" })]
    [DataRow('e', 7, new[] { "a7", "b7", "c7", "d7", "f7", "g7", "h7", "e1", "e2", "e3", "e4", "e5", "e6", "e8" })]
    [DataRow('e', 8, new[] { "a8", "b8", "c8", "d8", "f8", "g8", "h8", "e1", "e2", "e3", "e4", "e5", "e6", "e7" })]
    [DataRow('f', 1, new[] { "a1", "b1", "c1", "d1", "e1", "g1", "h1", "f2", "f3", "f4", "f5", "f6", "f7", "f8" })]
    [DataRow('f', 2, new[] { "a2", "b2", "c2", "d2", "e2", "g2", "h2", "f1", "f3", "f4", "f5", "f6", "f7", "f8" })]
    [DataRow('f', 3, new[] { "a3", "b3", "c3", "d3", "e3", "g3", "h3", "f1", "f2", "f4", "f5", "f6", "f7", "f8" })]
    [DataRow('f', 4, new[] { "a4", "b4", "c4", "d4", "e4", "g4", "h4", "f1", "f2", "f3", "f5", "f6", "f7", "f8" })]
    [DataRow('f', 5, new[] { "a5", "b5", "c5", "d5", "e5", "g5", "h5", "f1", "f2", "f3", "f4", "f6", "f7", "f8" })]
    [DataRow('f', 6, new[] { "a6", "b6", "c6", "d6", "e6", "g6", "h6", "f1", "f2", "f3", "f4", "f5", "f7", "f8" })]
    [DataRow('f', 7, new[] { "a7", "b7", "c7", "d7", "e7", "g7", "h7", "f1", "f2", "f3", "f4", "f5", "f6", "f8" })]
    [DataRow('f', 8, new[] { "a8", "b8", "c8", "d8", "e8", "g8", "h8", "f1", "f2", "f3", "f4", "f5", "f6", "f7" })]
    [DataRow('g', 1, new[] { "a1", "b1", "c1", "d1", "e1", "f1", "h1", "g2", "g3", "g4", "g5", "g6", "g7", "g8" })]
    [DataRow('g', 2, new[] { "a2", "b2", "c2", "d2", "e2", "f2", "h2", "g1", "g3", "g4", "g5", "g6", "g7", "g8" })]
    [DataRow('g', 3, new[] { "a3", "b3", "c3", "d3", "e3", "f3", "h3", "g1", "g2", "g4", "g5", "g6", "g7", "g8" })]
    [DataRow('g', 4, new[] { "a4", "b4", "c4", "d4", "e4", "f4", "h4", "g1", "g2", "g3", "g5", "g6", "g7", "g8" })]
    [DataRow('g', 5, new[] { "a5", "b5", "c5", "d5", "e5", "f5", "h5", "g1", "g2", "g3", "g4", "g6", "g7", "g8" })]
    [DataRow('g', 6, new[] { "a6", "b6", "c6", "d6", "e6", "f6", "h6", "g1", "g2", "g3", "g4", "g5", "g7", "g8" })]
    [DataRow('g', 7, new[] { "a7", "b7", "c7", "d7", "e7", "f7", "h7", "g1", "g2", "g3", "g4", "g5", "g6", "g8" })]
    [DataRow('g', 8, new[] { "a8", "b8", "c8", "d8", "e8", "f8", "h8", "g1", "g2", "g3", "g4", "g5", "g6", "g7" })]
    [DataRow('h', 1, new[] { "a1", "b1", "c1", "d1", "e1", "f1", "g1", "h2", "h3", "h4", "h5", "h6", "h7", "h8" })]
    [DataRow('h', 2, new[] { "a2", "b2", "c2", "d2", "e2", "f2", "g2", "h1", "h3", "h4", "h5", "h6", "h7", "h8" })]
    [DataRow('h', 3, new[] { "a3", "b3", "c3", "d3", "e3", "f3", "g3", "h1", "h2", "h4", "h5", "h6", "h7", "h8" })]
    [DataRow('h', 4, new[] { "a4", "b4", "c4", "d4", "e4", "f4", "g4", "h1", "h2", "h3", "h5", "h6", "h7", "h8" })]
    [DataRow('h', 5, new[] { "a5", "b5", "c5", "d5", "e5", "f5", "g5", "h1", "h2", "h3", "h4", "h6", "h7", "h8" })]
    [DataRow('h', 6, new[] { "a6", "b6", "c6", "d6", "e6", "f6", "g6", "h1", "h2", "h3", "h4", "h5", "h7", "h8" })]
    [DataRow('h', 7, new[] { "a7", "b7", "c7", "d7", "e7", "f7", "g7", "h1", "h2", "h3", "h4", "h5", "h6", "h8" })]
    [DataRow('h', 8, new[] { "a8", "b8", "c8", "d8", "e8", "f8", "g8", "h1", "h2", "h3", "h4", "h5", "h6", "h7" })]
    public void GetValidMoves_Rook_AllPossiblePositions(char rank, int file, string[] expectedSquares)
    {
        var board = new Board();
        foreach (Piece.PieceColour colour in Enum.GetValues(typeof(Piece.PieceColour)))
        {
            var piece = new Rook(colour);
            board.GetSquare(rank, file).Piece = piece;

            var possibleMoves = piece.GetValidMoves(board);

            var expectedMoves = expectedSquares.Select(sq =>
            {
                return board.GetSquare((char)sq[0], int.Parse(sq[1].ToString()));
            });

            CollectionAssert.AreEquivalent(expectedMoves.ToList(), possibleMoves.ToList(), "The valid moves for the rook are not as expected. " +
                $"Actual: {string.Join(", ", possibleMoves.Select(sq => $"{sq.Rank}{sq.File}"))}");
        }
    }

    [DataTestMethod]
    [DataRow('a', 1, "a2", new[] { "a2", "b1", "c1", "d1", "e1", "f1", "g1", "h1" })]
    [DataRow('a', 1, "a3", new[] { "a2", "a3", "b1", "c1", "d1", "e1", "f1", "g1", "h1" })]
    [DataRow('a', 1, "a4", new[] { "a2", "a3", "a4", "b1", "c1", "d1", "e1", "f1", "g1", "h1" })]
    [DataRow('a', 1, "a5", new[] { "a2", "a3", "a4", "a5", "b1", "c1", "d1", "e1", "f1", "g1", "h1" })]
    [DataRow('a', 1, "a6", new[] { "a2", "a3", "a4", "a5", "a6", "b1", "c1", "d1", "e1", "f1", "g1", "h1" })]
    [DataRow('a', 1, "a7", new[] { "a2", "a3", "a4", "a5", "a6", "a7", "b1", "c1", "d1", "e1", "f1", "g1", "h1" })]
    [DataRow('a', 1, "a8", new[] { "a2", "a3", "a4", "a5", "a6", "a7", "a8", "b1", "c1", "d1", "e1", "f1", "g1", "h1" })]
    [DataRow('a', 1, "b1", new[] { "a2", "a3", "a4", "a5", "a6", "a7", "a8", "b1" })]
    [DataRow('a', 1, "c1", new[] { "a2", "a3", "a4", "a5", "a6", "a7", "a8", "b1", "c1" })]
    [DataRow('a', 1, "d1", new[] { "a2", "a3", "a4", "a5", "a6", "a7", "a8", "b1", "c1", "d1" })]
    [DataRow('a', 1, "e1", new[] { "a2", "a3", "a4", "a5", "a6", "a7", "a8", "b1", "c1", "d1", "e1" })]
    [DataRow('a', 1, "f1", new[] { "a2", "a3", "a4", "a5", "a6", "a7", "a8", "b1", "c1", "d1", "e1", "f1" })]
    [DataRow('a', 1, "g1", new[] { "a2", "a3", "a4", "a5", "a6", "a7", "a8", "b1", "c1", "d1", "e1", "f1", "g1" })]
    [DataRow('a', 1, "h1", new[] { "a2", "a3", "a4", "a5", "a6", "a7", "a8", "b1", "c1", "d1", "e1", "f1", "g1", "h1" })]
    [DataRow('h', 1, "h2", new[] { "h2", "a1", "b1", "c1", "d1", "e1", "f1", "g1" })]
    [DataRow('h', 1, "h3", new[] { "h2", "h3", "a1", "b1", "c1", "d1", "e1", "f1", "g1" })]
    [DataRow('h', 1, "h4", new[] { "h2", "h3", "h4", "a1", "b1", "c1", "d1", "e1", "f1", "g1" })]
    [DataRow('h', 1, "h5", new[] { "h2", "h3", "h4", "h5", "a1", "b1", "c1", "d1", "e1", "f1", "g1" })]
    [DataRow('h', 1, "h6", new[] { "h2", "h3", "h4", "h5", "h6", "a1", "b1", "c1", "d1", "e1", "f1", "g1" })]
    [DataRow('h', 1, "h7", new[] { "h2", "h3", "h4", "h5", "h6", "h7", "a1", "b1", "c1", "d1", "e1", "f1", "g1" })]
    [DataRow('h', 1, "h8", new[] { "h2", "h3", "h4", "h5", "h6", "h7", "h8", "a1", "b1", "c1", "d1", "e1", "f1", "g1" })]
    [DataRow('h', 1, "g1", new[] { "h2", "h3", "h4", "h5", "h6", "h7", "h8", "g1" })]
    [DataRow('h', 1, "f1", new[] { "h2", "h3", "h4", "h5", "h6", "h7", "h8", "g1", "f1" })]
    [DataRow('h', 1, "e1", new[] { "h2", "h3", "h4", "h5", "h6", "h7", "h8", "g1", "f1", "e1" })]
    [DataRow('h', 1, "d1", new[] { "h2", "h3", "h4", "h5", "h6", "h7", "h8", "g1", "f1", "e1", "d1" })]
    [DataRow('h', 1, "c1", new[] { "h2", "h3", "h4", "h5", "h6", "h7", "h8", "g1", "f1", "e1", "d1", "c1" })]
    [DataRow('h', 1, "b1", new[] { "h2", "h3", "h4", "h5", "h6", "h7", "h8", "g1", "f1", "e1", "d1", "c1", "b1" })]
    [DataRow('h', 1, "a1", new[] { "h2", "h3", "h4", "h5", "h6", "h7", "h8", "g1", "f1", "e1", "d1", "c1", "b1", "a1" })]
    [DataRow('a', 8, "a7", new[] { "a7", "b8", "c8", "d8", "e8", "f8", "g8", "h8" })]
    [DataRow('a', 8, "a6", new[] { "a7", "a6", "b8", "c8", "d8", "e8", "f8", "g8", "h8" })]
    [DataRow('a', 8, "a5", new[] { "a7", "a6", "a5", "b8", "c8", "d8", "e8", "f8", "g8", "h8" })]
    [DataRow('a', 8, "a4", new[] { "a7", "a6", "a5", "a4", "b8", "c8", "d8", "e8", "f8", "g8", "h8" })]
    [DataRow('a', 8, "a3", new[] { "a7", "a6", "a5", "a4", "a3", "b8", "c8", "d8", "e8", "f8", "g8", "h8" })]
    [DataRow('a', 8, "a2", new[] { "a7", "a6", "a5", "a4", "a3", "a2", "b8", "c8", "d8", "e8", "f8", "g8", "h8" })]
    [DataRow('a', 8, "a1", new[] { "a7", "a6", "a5", "a4", "a3", "a2", "a1", "b8", "c8", "d8", "e8", "f8", "g8", "h8" })]
    [DataRow('a', 8, "b8", new[] { "a7", "a6", "a5", "a4", "a3", "a2", "a1", "b8" })]
    [DataRow('a', 8, "c8", new[] { "a7", "a6", "a5", "a4", "a3", "a2", "a1", "b8", "c8" })]
    [DataRow('a', 8, "d8", new[] { "a7", "a6", "a5", "a4", "a3", "a2", "a1", "b8", "c8", "d8" })]
    [DataRow('a', 8, "e8", new[] { "a7", "a6", "a5", "a4", "a3", "a2", "a1", "b8", "c8", "d8", "e8" })]
    [DataRow('a', 8, "f8", new[] { "a7", "a6", "a5", "a4", "a3", "a2", "a1", "b8", "c8", "d8", "e8", "f8" })]
    [DataRow('a', 8, "g8", new[] { "a7", "a6", "a5", "a4", "a3", "a2", "a1", "b8", "c8", "d8", "e8", "f8", "g8" })]
    [DataRow('a', 8, "h8", new[] { "a7", "a6", "a5", "a4", "a3", "a2", "a1", "b8", "c8", "d8", "e8", "f8", "g8", "h8" })]
    [DataRow('h', 8, "h7", new[] { "h7", "a8", "b8", "c8", "d8", "e8", "f8", "g8" })]
    [DataRow('h', 8, "h6", new[] { "h7", "h6", "a8", "b8", "c8", "d8", "e8", "f8", "g8" })]
    [DataRow('h', 8, "h5", new[] { "h7", "h6", "h5", "a8", "b8", "c8", "d8", "e8", "f8", "g8" })]
    [DataRow('h', 8, "h4", new[] { "h7", "h6", "h5", "h4", "a8", "b8", "c8", "d8", "e8", "f8", "g8" })]
    [DataRow('h', 8, "h3", new[] { "h7", "h6", "h5", "h4", "h3", "a8", "b8", "c8", "d8", "e8", "f8", "g8" })]
    [DataRow('h', 8, "h2", new[] { "h7", "h6", "h5", "h4", "h3", "h2", "a8", "b8", "c8", "d8", "e8", "f8", "g8" })]
    [DataRow('h', 8, "h1", new[] { "h7", "h6", "h5", "h4", "h3", "h2", "h1", "a8", "b8", "c8", "d8", "e8", "f8", "g8" })]
    [DataRow('h', 8, "g8", new[] { "h7", "h6", "h5", "h4", "h3", "h2", "h1", "g8" })]
    [DataRow('h', 8, "f8", new[] { "h7", "h6", "h5", "h4", "h3", "h2", "h1", "g8", "f8" })]
    [DataRow('h', 8, "e8", new[] { "h7", "h6", "h5", "h4", "h3", "h2", "h1", "g8", "f8", "e8" })]
    [DataRow('h', 8, "d8", new[] { "h7", "h6", "h5", "h4", "h3", "h2", "h1", "g8", "f8", "e8", "d8" })]
    [DataRow('h', 8, "c8", new[] { "h7", "h6", "h5", "h4", "h3", "h2", "h1", "g8", "f8", "e8", "d8", "c8" })]
    [DataRow('h', 8, "b8", new[] { "h7", "h6", "h5", "h4", "h3", "h2", "h1", "g8", "f8", "e8", "d8", "c8", "b8" })]
    [DataRow('h', 8, "a8", new[] { "h7", "h6", "h5", "h4", "h3", "h2", "h1", "g8", "f8", "e8", "d8", "c8", "b8", "a8" })]
    [DataRow('d', 4, "d5", new[] { "d5", "d3", "d2", "d1", "a4", "b4", "c4", "e4", "f4", "g4", "h4" })]
    [DataRow('d', 4, "d3", new[] { "d3", "d5", "d6", "d7", "d8", "a4", "b4", "c4", "e4", "f4", "g4", "h4" })]
    [DataRow('d', 4, "e4", new[] { "d5", "d6", "d7", "d8", "e4", "d3", "d2", "d1", "a4", "b4", "c4" })]
    [DataRow('d', 4, "c4", new[] { "d5", "d6", "d7", "d8", "c4", "e4", "f4", "g4", "h4", "d3", "d2", "d1" })]

    public void GetValidMoves_Rook_PieceCanBeCaptured_AllPossiblePositions(char rank, int file, string capturedPiece, string[] expectedSquares)
    {
        var board = new Board();
        foreach (Piece.PieceColour colour in Enum.GetValues(typeof(Piece.PieceColour)))
        {
            var piece = new Rook(colour);
            board.GetSquare(rank, file).Piece = piece;

            var targetSquare = board.GetSquare((char)capturedPiece[0], int.Parse(capturedPiece[1].ToString()));
            targetSquare.Piece = new Pawn(colour == Piece.PieceColour.White ? Piece.PieceColour.Black : Piece.PieceColour.White);

            var possibleMoves = piece.GetValidMoves(board);

            var expectedMoves = expectedSquares.Select(sq =>
            {
                return board.GetSquare((char)sq[0], int.Parse(sq[1].ToString()));
            });

            CollectionAssert.AreEquivalent(expectedMoves.ToList(), possibleMoves.ToList(), "The valid moves for the rook are not as expected. " +
                $"Actual: {string.Join(", ", possibleMoves.Select(sq => $"{sq.Rank}{sq.File}"))}");
        }
    }

    [DataTestMethod]
    [DataRow('a', 1, "a2", new[] { "b1", "c1", "d1", "e1", "f1", "g1", "h1" })]
    [DataRow('a', 1, "a3", new[] { "a2", "b1", "c1", "d1", "e1", "f1", "g1", "h1" })]
    [DataRow('a', 1, "a4", new[] { "a2", "a3", "b1", "c1", "d1", "e1", "f1", "g1", "h1" })]
    [DataRow('a', 1, "a5", new[] { "a2", "a3", "a4", "b1", "c1", "d1", "e1", "f1", "g1", "h1" })]
    [DataRow('a', 1, "a6", new[] { "a2", "a3", "a4", "a5", "b1", "c1", "d1", "e1", "f1", "g1", "h1" })]
    [DataRow('a', 1, "a7", new[] { "a2", "a3", "a4", "a5", "a6", "b1", "c1", "d1", "e1", "f1", "g1", "h1" })]
    [DataRow('a', 1, "a8", new[] { "a2", "a3", "a4", "a5", "a6", "a7", "b1", "c1", "d1", "e1", "f1", "g1", "h1" })]
    [DataRow('a', 1, "b1", new[] { "a2", "a3", "a4", "a5", "a6", "a7", "a8" })]
    [DataRow('a', 1, "c1", new[] { "a2", "a3", "a4", "a5", "a6", "a7", "a8", "b1" })]
    [DataRow('a', 1, "d1", new[] { "a2", "a3", "a4", "a5", "a6", "a7", "a8", "b1", "c1" })]
    [DataRow('a', 1, "e1", new[] { "a2", "a3", "a4", "a5", "a6", "a7", "a8", "b1", "c1", "d1" })]
    [DataRow('a', 1, "f1", new[] { "a2", "a3", "a4", "a5", "a6", "a7", "a8", "b1", "c1", "d1", "e1" })]
    [DataRow('a', 1, "g1", new[] { "a2", "a3", "a4", "a5", "a6", "a7", "a8", "b1", "c1", "d1", "e1", "f1" })]
    [DataRow('a', 1, "h1", new[] { "a2", "a3", "a4", "a5", "a6", "a7", "a8", "b1", "c1", "d1", "e1", "f1", "g1" })]
    [DataRow('h', 1, "h2", new[] { "g1", "f1", "e1", "d1", "c1", "b1", "a1" })]
    [DataRow('h', 1, "h3", new[] { "h2", "g1", "f1", "e1", "d1", "c1", "b1", "a1" })]
    [DataRow('h', 1, "h4", new[] { "h2", "h3", "g1", "f1", "e1", "d1", "c1", "b1", "a1" })]
    [DataRow('h', 1, "h5", new[] { "h2", "h3", "h4", "g1", "f1", "e1", "d1", "c1", "b1", "a1" })]
    [DataRow('h', 1, "h6", new[] { "h2", "h3", "h4", "h5", "g1", "f1", "e1", "d1", "c1", "b1", "a1" })]
    [DataRow('h', 1, "h7", new[] { "h2", "h3", "h4", "h5", "h6", "g1", "f1", "e1", "d1", "c1", "b1", "a1" })]
    [DataRow('h', 1, "h8", new[] { "h2", "h3", "h4", "h5", "h6", "h7", "g1", "f1", "e1", "d1", "c1", "b1", "a1" })]
    [DataRow('h', 1, "g1", new[] { "h2", "h3", "h4", "h5", "h6", "h7", "h8" })]
    [DataRow('h', 1, "f1", new[] { "h2", "h3", "h4", "h5", "h6", "h7", "h8", "g1" })]
    [DataRow('h', 1, "e1", new[] { "h2", "h3", "h4", "h5", "h6", "h7", "h8", "g1", "f1" })]
    [DataRow('h', 1, "d1", new[] { "h2", "h3", "h4", "h5", "h6", "h7", "h8", "g1", "f1", "e1" })]
    [DataRow('h', 1, "c1", new[] { "h2", "h3", "h4", "h5", "h6", "h7", "h8", "g1", "f1", "e1", "d1" })]
    [DataRow('h', 1, "b1", new[] { "h2", "h3", "h4", "h5", "h6", "h7", "h8", "g1", "f1", "e1", "d1", "c1" })]
    [DataRow('h', 1, "a1", new[] { "h2", "h3", "h4", "h5", "h6", "h7", "h8", "g1", "f1", "e1", "d1", "c1", "b1" })]
    [DataRow('a', 8, "a7", new[] { "b8", "c8", "d8", "e8", "f8", "g8", "h8" })]
    [DataRow('a', 8, "a6", new[] { "a7", "b8", "c8", "d8", "e8", "f8", "g8", "h8" })]
    [DataRow('a', 8, "a5", new[] { "a7", "a6", "b8", "c8", "d8", "e8", "f8", "g8", "h8" })]
    [DataRow('a', 8, "a4", new[] { "a7", "a6", "a5", "b8", "c8", "d8", "e8", "f8", "g8", "h8" })]
    [DataRow('a', 8, "a3", new[] { "a7", "a6", "a5", "a4", "b8", "c8", "d8", "e8", "f8", "g8", "h8" })]
    [DataRow('a', 8, "a2", new[] { "a7", "a6", "a5", "a4", "a3", "b8", "c8", "d8", "e8", "f8", "g8", "h8" })]
    [DataRow('a', 8, "a1", new[] { "a7", "a6", "a5", "a4", "a3", "a2", "b8", "c8", "d8", "e8", "f8", "g8", "h8" })]
    [DataRow('a', 8, "b8", new[] { "a7", "a6", "a5", "a4", "a3", "a2", "a1" })]
    [DataRow('a', 8, "c8", new[] { "a7", "a6", "a5", "a4", "a3", "a2", "a1", "b8" })]
    [DataRow('a', 8, "d8", new[] { "a7", "a6", "a5", "a4", "a3", "a2", "a1", "b8", "c8" })]
    [DataRow('a', 8, "e8", new[] { "a7", "a6", "a5", "a4", "a3", "a2", "a1", "b8", "c8", "d8" })]
    [DataRow('a', 8, "f8", new[] { "a7", "a6", "a5", "a4", "a3", "a2", "a1", "b8", "c8", "d8", "e8" })]
    [DataRow('a', 8, "g8", new[] { "a7", "a6", "a5", "a4", "a3", "a2", "a1", "b8", "c8", "d8", "e8", "f8" })]
    [DataRow('a', 8, "h8", new[] { "a7", "a6", "a5", "a4", "a3", "a2", "a1", "b8", "c8", "d8", "e8", "f8", "g8" })]
    [DataRow('h', 8, "h7", new[] { "g8", "f8", "e8", "d8", "c8", "b8", "a8" })]
    [DataRow('h', 8, "h6", new[] { "h7", "g8", "f8", "e8", "d8", "c8", "b8", "a8" })]
    [DataRow('h', 8, "h5", new[] { "h7", "h6", "g8", "f8", "e8", "d8", "c8", "b8", "a8" })]
    [DataRow('h', 8, "h4", new[] { "h7", "h6", "h5", "g8", "f8", "e8", "d8", "c8", "b8", "a8" })]
    [DataRow('h', 8, "h3", new[] { "h7", "h6", "h5", "h4", "g8", "f8", "e8", "d8", "c8", "b8", "a8" })]
    [DataRow('h', 8, "h2", new[] { "h7", "h6", "h5", "h4", "h3", "g8", "f8", "e8", "d8", "c8", "b8", "a8" })]
    [DataRow('h', 8, "h1", new[] { "h7", "h6", "h5", "h4", "h3", "h2", "g8", "f8", "e8", "d8", "c8", "b8", "a8" })]
    [DataRow('h', 8, "g8", new[] { "h7", "h6", "h5", "h4", "h3", "h2", "h1" })]
    [DataRow('h', 8, "f8", new[] { "h7", "h6", "h5", "h4", "h3", "h2", "h1", "g8" })]
    [DataRow('h', 8, "e8", new[] { "h7", "h6", "h5", "h4", "h3", "h2", "h1", "g8", "f8" })]
    [DataRow('h', 8, "d8", new[] { "h7", "h6", "h5", "h4", "h3", "h2", "h1", "g8", "f8", "e8" })]
    [DataRow('h', 8, "c8", new[] { "h7", "h6", "h5", "h4", "h3", "h2", "h1", "g8", "f8", "e8", "d8" })]
    [DataRow('h', 8, "b8", new[] { "h7", "h6", "h5", "h4", "h3", "h2", "h1", "g8", "f8", "e8", "d8", "c8" })]
    [DataRow('h', 8, "a8", new[] { "h7", "h6", "h5", "h4", "h3", "h2", "h1", "g8", "f8", "e8", "d8", "c8", "b8" })]
    [DataRow('d', 4, "d5", new[] { "a4", "b4", "c4", "e4", "f4", "g4", "h4", "d3", "d2", "d1" })]
    [DataRow('d', 4, "d3", new[] { "d5", "d6", "d7", "d8", "e4", "f4", "g4", "h4", "a4", "b4", "c4" })]
    [DataRow('d', 4, "e4", new[] { "d5", "d6", "d7", "d8", "a4", "b4", "c4", "d3", "d2", "d1" })]
    [DataRow('d', 4, "c4", new[] { "d5", "d6", "d7", "d8", "e4", "f4", "g4", "h4", "d3", "d2", "d1" })]

    public void GetValidMoves_Rook_PieceSameColourInPath_AllPossiblePositions(char rank, int file, string blockedPiece, string[] expectedSquares)
    {
        var board = new Board();
        foreach (Piece.PieceColour colour in Enum.GetValues(typeof(Piece.PieceColour)))
        {
            var piece = new Rook(colour);
            board.GetSquare(rank, file).Piece = piece;

            var targetSquare = board.GetSquare((char)blockedPiece[0], int.Parse(blockedPiece[1].ToString()));
            targetSquare.Piece = new Pawn(colour);

            var possibleMoves = piece.GetValidMoves(board);

            var expectedMoves = expectedSquares.Select(sq =>
            {
                return board.GetSquare((char)sq[0], int.Parse(sq[1].ToString()));
            });

            CollectionAssert.AreEquivalent(expectedMoves.ToList(), possibleMoves.ToList(), "The valid moves for the rook are not as expected. " +
                $"Actual: {string.Join(", ", possibleMoves.Select(sq => $"{sq.Rank}{sq.File}"))}");
        }
    }
}
