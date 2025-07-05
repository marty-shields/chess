using chess.engine.components;

namespace chess.engine.unit.tests.components;

[TestClass]
public class KnightTests
{
    [TestMethod]
    public void GetValidMoves_KnightNotOnBoard_ThrowsException()
    {
        var board = new Board();
        var piece = new Knight(Piece.PieceColour.White);

        var ex = Assert.ThrowsException<InvalidOperationException>(() => piece.GetValidMoves(board));
        Assert.AreEqual("Knight is not on the board.", ex.Message);
    }

    [DataTestMethod]
    [DataRow('a', 1, new[] { "b3", "c2" })]
    [DataRow('a', 2, new[] { "b4", "c1", "c3" })]
    [DataRow('a', 3, new[] { "b1", "b5", "c2", "c4" })]
    [DataRow('a', 4, new[] { "b2", "b6", "c3", "c5" })]
    [DataRow('a', 5, new[] { "b3", "b7", "c4", "c6" })]
    [DataRow('a', 6, new[] { "b4", "b8", "c5", "c7" })]
    [DataRow('a', 7, new[] { "b5", "c6", "c8" })]
    [DataRow('a', 8, new[] { "b6", "c7" })]
    [DataRow('b', 1, new[] { "a3", "c3", "d2" })]
    [DataRow('b', 2, new[] { "a4", "c4", "d1", "d3" })]
    [DataRow('b', 3, new[] { "a1", "a5", "c1", "c5", "d2", "d4" })]
    [DataRow('b', 4, new[] { "a2", "a6", "c2", "c6", "d3", "d5" })]
    [DataRow('b', 5, new[] { "a3", "a7", "c3", "c7", "d4", "d6" })]
    [DataRow('b', 6, new[] { "a4", "a8", "c4", "c8", "d5", "d7" })]
    [DataRow('b', 7, new[] { "a5", "c5", "d6", "d8" })]
    [DataRow('b', 8, new[] { "a6", "c6", "d7" })]
    [DataRow('c', 1, new[] { "a2", "b3", "d3", "e2" })]
    [DataRow('c', 2, new[] { "a1", "a3", "b4", "d4", "e1", "e3" })]
    [DataRow('c', 3, new[] { "a2", "a4", "b1", "b5", "d1", "d5", "e2", "e4" })]
    [DataRow('c', 4, new[] { "a3", "a5", "b2", "b6", "d2", "d6", "e3", "e5" })]
    [DataRow('c', 5, new[] { "a4", "a6", "b3", "b7", "d3", "d7", "e4", "e6" })]
    [DataRow('c', 6, new[] { "a5", "a7", "b4", "b8", "d4", "d8", "e5", "e7" })]
    [DataRow('c', 7, new[] { "a6", "a8", "b5", "d5", "e6", "e8" })]
    [DataRow('c', 8, new[] { "a7", "b6", "d6", "e7" })]
    [DataRow('d', 1, new[] { "b2", "c3", "e3", "f2" })]
    [DataRow('d', 2, new[] { "b1", "b3", "c4", "e4", "f1", "f3" })]
    [DataRow('d', 3, new[] { "b2", "b4", "c1", "c5", "e1", "e5", "f2", "f4" })]
    [DataRow('d', 4, new[] { "b3", "b5", "c2", "c6", "e2", "e6", "f3", "f5" })]
    [DataRow('d', 5, new[] { "b4", "b6", "c3", "c7", "e3", "e7", "f4", "f6" })]
    [DataRow('d', 6, new[] { "b5", "b7", "c4", "c8", "e4", "e8", "f5", "f7" })]
    [DataRow('d', 7, new[] { "b6", "b8", "c5", "e5", "f6", "f8" })]
    [DataRow('d', 8, new[] { "b7", "c6", "e6", "f7" })]
    [DataRow('e', 1, new[] { "c2", "d3", "f3", "g2" })]
    [DataRow('e', 2, new[] { "c1", "c3", "d4", "f4", "g1", "g3" })]
    [DataRow('e', 3, new[] { "c2", "c4", "d1", "d5", "f1", "f5", "g2", "g4" })]
    [DataRow('e', 4, new[] { "c3", "c5", "d2", "d6", "f2", "f6", "g3", "g5" })]
    [DataRow('e', 5, new[] { "c4", "c6", "d3", "d7", "f3", "f7", "g4", "g6" })]
    [DataRow('e', 6, new[] { "c5", "c7", "d4", "d8", "f4", "f8", "g5", "g7" })]
    [DataRow('e', 7, new[] { "c6", "c8", "d5", "f5", "g6", "g8" })]
    [DataRow('e', 8, new[] { "c7", "d6", "f6", "g7" })]
    [DataRow('f', 1, new[] { "d2", "e3", "g3", "h2" })]
    [DataRow('f', 2, new[] { "d1", "d3", "e4", "g4", "h1", "h3" })]
    [DataRow('f', 3, new[] { "d2", "d4", "e1", "e5", "g1", "g5", "h2", "h4" })]
    [DataRow('f', 4, new[] { "d3", "d5", "e2", "e6", "g2", "g6", "h3", "h5" })]
    [DataRow('f', 5, new[] { "d4", "d6", "e3", "e7", "g3", "g7", "h4", "h6" })]
    [DataRow('f', 6, new[] { "d5", "d7", "e4", "e8", "g4", "g8", "h5", "h7" })]
    [DataRow('f', 7, new[] { "d6", "d8", "e5", "g5", "h6", "h8" })]
    [DataRow('f', 8, new[] { "d7", "e6", "g6", "h7" })]
    [DataRow('g', 1, new[] { "e2", "f3", "h3" })]
    [DataRow('g', 2, new[] { "e1", "e3", "f4", "h4" })]
    [DataRow('g', 3, new[] { "e2", "e4", "f1", "f5", "h1", "h5" })]
    [DataRow('g', 4, new[] { "e3", "e5", "f2", "f6", "h2", "h6" })]
    [DataRow('g', 5, new[] { "e4", "e6", "f3", "f7", "h3", "h7" })]
    [DataRow('g', 6, new[] { "e5", "e7", "f4", "f8", "h4", "h8" })]
    [DataRow('g', 7, new[] { "e6", "e8", "f5", "h5" })]
    [DataRow('g', 8, new[] { "e7", "f6", "h6" })]
    [DataRow('h', 1, new[] { "f2", "g3" })]
    [DataRow('h', 2, new[] { "f1", "f3", "g4" })]
    [DataRow('h', 3, new[] { "f2", "f4", "g1", "g5" })]
    [DataRow('h', 4, new[] { "f3", "f5", "g2", "g6" })]
    [DataRow('h', 5, new[] { "f4", "f6", "g3", "g7" })]
    [DataRow('h', 6, new[] { "f5", "f7", "g4", "g8" })]
    [DataRow('h', 7, new[] { "f6", "f8", "g5" })]
    [DataRow('h', 8, new[] { "f7", "g6" })]
    public void GetValidMoves_Knight_AllPossiblePositions(char rank, int file, string[] expectedSquares)
    {
        var board = new Board();
        foreach (Piece.PieceColour colour in Enum.GetValues(typeof(Piece.PieceColour)))
        {
            var piece = new Knight(colour);
            board.GetSquare(rank, file).Piece = piece;

            var possibleMoves = piece.GetValidMoves(board);

            var expectedMoves = expectedSquares.Select(sq =>
            {
                return board.GetSquare((char)sq[0], int.Parse(sq[1].ToString()));
            });

            CollectionAssert.AreEquivalent(expectedMoves.ToList(), possibleMoves.ToList());
        }
    }

    [DataTestMethod]
    [DataRow('a', 1, new[] { "b3", "c2" })]
    [DataRow('a', 2, new[] { "b4", "c1", "c3" })]
    [DataRow('a', 3, new[] { "b1", "b5", "c2", "c4" })]
    [DataRow('a', 4, new[] { "b2", "b6", "c3", "c5" })]
    [DataRow('a', 5, new[] { "b3", "b7", "c4", "c6" })]
    [DataRow('a', 6, new[] { "b4", "b8", "c5", "c7" })]
    [DataRow('a', 7, new[] { "b5", "c6", "c8" })]
    [DataRow('a', 8, new[] { "b6", "c7" })]
    [DataRow('b', 1, new[] { "a3", "c3", "d2" })]
    [DataRow('b', 2, new[] { "a4", "c4", "d1", "d3" })]
    [DataRow('b', 3, new[] { "a1", "a5", "c1", "c5", "d2", "d4" })]
    [DataRow('b', 4, new[] { "a2", "a6", "c2", "c6", "d3", "d5" })]
    [DataRow('b', 5, new[] { "a3", "a7", "c3", "c7", "d4", "d6" })]
    [DataRow('b', 6, new[] { "a4", "a8", "c4", "c8", "d5", "d7" })]
    [DataRow('b', 7, new[] { "a5", "c5", "d6", "d8" })]
    [DataRow('b', 8, new[] { "a6", "c6", "d7" })]
    [DataRow('c', 1, new[] { "a2", "b3", "d3", "e2" })]
    [DataRow('c', 2, new[] { "a1", "a3", "b4", "d4", "e1", "e3" })]
    [DataRow('c', 3, new[] { "a2", "a4", "b1", "b5", "d1", "d5", "e2", "e4" })]
    [DataRow('c', 4, new[] { "a3", "a5", "b2", "b6", "d2", "d6", "e3", "e5" })]
    [DataRow('c', 5, new[] { "a4", "a6", "b3", "b7", "d3", "d7", "e4", "e6" })]
    [DataRow('c', 6, new[] { "a5", "a7", "b4", "b8", "d4", "d8", "e5", "e7" })]
    [DataRow('c', 7, new[] { "a6", "a8", "b5", "d5", "e6", "e8" })]
    [DataRow('c', 8, new[] { "a7", "b6", "d6", "e7" })]
    [DataRow('d', 1, new[] { "b2", "c3", "e3", "f2" })]
    [DataRow('d', 2, new[] { "b1", "b3", "c4", "e4", "f1", "f3" })]
    [DataRow('d', 3, new[] { "b2", "b4", "c1", "c5", "e1", "e5", "f2", "f4" })]
    [DataRow('d', 4, new[] { "b3", "b5", "c2", "c6", "e2", "e6", "f3", "f5" })]
    [DataRow('d', 5, new[] { "b4", "b6", "c3", "c7", "e3", "e7", "f4", "f6" })]
    [DataRow('d', 6, new[] { "b5", "b7", "c4", "c8", "e4", "e8", "f5", "f7" })]
    [DataRow('d', 7, new[] { "b6", "b8", "c5", "e5", "f6", "f8" })]
    [DataRow('d', 8, new[] { "b7", "c6", "e6", "f7" })]
    [DataRow('e', 1, new[] { "c2", "d3", "f3", "g2" })]
    [DataRow('e', 2, new[] { "c1", "c3", "d4", "f4", "g1", "g3" })]
    [DataRow('e', 3, new[] { "c2", "c4", "d1", "d5", "f1", "f5", "g2", "g4" })]
    [DataRow('e', 4, new[] { "c3", "c5", "d2", "d6", "f2", "f6", "g3", "g5" })]
    [DataRow('e', 5, new[] { "c4", "c6", "d3", "d7", "f3", "f7", "g4", "g6" })]
    [DataRow('e', 6, new[] { "c5", "c7", "d4", "d8", "f4", "f8", "g5", "g7" })]
    [DataRow('e', 7, new[] { "c6", "c8", "d5", "f5", "g6", "g8" })]
    [DataRow('e', 8, new[] { "c7", "d6", "f6", "g7" })]
    [DataRow('f', 1, new[] { "d2", "e3", "g3", "h2" })]
    [DataRow('f', 2, new[] { "d1", "d3", "e4", "g4", "h1", "h3" })]
    [DataRow('f', 3, new[] { "d2", "d4", "e1", "e5", "g1", "g5", "h2", "h4" })]
    [DataRow('f', 4, new[] { "d3", "d5", "e2", "e6", "g2", "g6", "h3", "h5" })]
    [DataRow('f', 5, new[] { "d4", "d6", "e3", "e7", "g3", "g7", "h4", "h6" })]
    [DataRow('f', 6, new[] { "d5", "d7", "e4", "e8", "g4", "g8", "h5", "h7" })]
    [DataRow('f', 7, new[] { "d6", "d8", "e5", "g5", "h6", "h8" })]
    [DataRow('f', 8, new[] { "d7", "e6", "g6", "h7" })]
    [DataRow('g', 1, new[] { "e2", "f3", "h3" })]
    [DataRow('g', 2, new[] { "e1", "e3", "f4", "h4" })]
    [DataRow('g', 3, new[] { "e2", "e4", "f1", "f5", "h1", "h5" })]
    [DataRow('g', 4, new[] { "e3", "e5", "f2", "f6", "h2", "h6" })]
    [DataRow('g', 5, new[] { "e4", "e6", "f3", "f7", "h3", "h7" })]
    [DataRow('g', 6, new[] { "e5", "e7", "f4", "f8", "h4", "h8" })]
    [DataRow('g', 7, new[] { "e6", "e8", "f5", "h5" })]
    [DataRow('g', 8, new[] { "e7", "f6", "h6" })]
    [DataRow('h', 1, new[] { "f2", "g3" })]
    [DataRow('h', 2, new[] { "f1", "f3", "g4" })]
    [DataRow('h', 3, new[] { "f2", "f4", "g1", "g5" })]
    [DataRow('h', 4, new[] { "f3", "f5", "g2", "g6" })]
    [DataRow('h', 5, new[] { "f4", "f6", "g3", "g7" })]
    [DataRow('h', 6, new[] { "f5", "f7", "g4", "g8" })]
    [DataRow('h', 7, new[] { "f6", "f8", "g5" })]
    [DataRow('h', 8, new[] { "f7", "g6" })]
    public void GetValidMoves_Knight_AllPossiblePositionsWhenSpaceTaken(char rank, int file, string[] expectedSquares)
    {
        var board = new Board();
        foreach (Piece.PieceColour colour in Enum.GetValues(typeof(Piece.PieceColour)))
        {
            var piece = new Knight(colour);
            board.GetSquare(rank, file).Piece = piece;

            for (int i = 0; i < expectedSquares.Length; i++)
            {
                var square = expectedSquares[i];
                var targetSquare = board.GetSquare((char)square[0], int.Parse(square[1].ToString()));
                targetSquare.Piece = new Pawn(colour);

                var possibleMoves = piece.GetValidMoves(board);
                var expectedMoves = expectedSquares.Where(sq =>
                {
                    var expSquare = board.GetSquare((char)sq[0], int.Parse(sq[1].ToString()));
                    return expSquare != targetSquare;
                }).Select(sq =>
                {
                    return board.GetSquare((char)sq[0], int.Parse(sq[1].ToString()));
                });

                CollectionAssert.AreEquivalent(expectedMoves.ToList(), possibleMoves.ToList());
                targetSquare.Piece = null;
            }
        }
    }

    [DataTestMethod]
    [DataRow('a', 1, new[] { "b3", "c2" })]
    [DataRow('a', 2, new[] { "b4", "c1", "c3" })]
    [DataRow('a', 3, new[] { "b1", "b5", "c2", "c4" })]
    [DataRow('a', 4, new[] { "b2", "b6", "c3", "c5" })]
    [DataRow('a', 5, new[] { "b3", "b7", "c4", "c6" })]
    [DataRow('a', 6, new[] { "b4", "b8", "c5", "c7" })]
    [DataRow('a', 7, new[] { "b5", "c6", "c8" })]
    [DataRow('a', 8, new[] { "b6", "c7" })]
    [DataRow('b', 1, new[] { "a3", "c3", "d2" })]
    [DataRow('b', 2, new[] { "a4", "c4", "d1", "d3" })]
    [DataRow('b', 3, new[] { "a1", "a5", "c1", "c5", "d2", "d4" })]
    [DataRow('b', 4, new[] { "a2", "a6", "c2", "c6", "d3", "d5" })]
    [DataRow('b', 5, new[] { "a3", "a7", "c3", "c7", "d4", "d6" })]
    [DataRow('b', 6, new[] { "a4", "a8", "c4", "c8", "d5", "d7" })]
    [DataRow('b', 7, new[] { "a5", "c5", "d6", "d8" })]
    [DataRow('b', 8, new[] { "a6", "c6", "d7" })]
    [DataRow('c', 1, new[] { "a2", "b3", "d3", "e2" })]
    [DataRow('c', 2, new[] { "a1", "a3", "b4", "d4", "e1", "e3" })]
    [DataRow('c', 3, new[] { "a2", "a4", "b1", "b5", "d1", "d5", "e2", "e4" })]
    [DataRow('c', 4, new[] { "a3", "a5", "b2", "b6", "d2", "d6", "e3", "e5" })]
    [DataRow('c', 5, new[] { "a4", "a6", "b3", "b7", "d3", "d7", "e4", "e6" })]
    [DataRow('c', 6, new[] { "a5", "a7", "b4", "b8", "d4", "d8", "e5", "e7" })]
    [DataRow('c', 7, new[] { "a6", "a8", "b5", "d5", "e6", "e8" })]
    [DataRow('c', 8, new[] { "a7", "b6", "d6", "e7" })]
    [DataRow('d', 1, new[] { "b2", "c3", "e3", "f2" })]
    [DataRow('d', 2, new[] { "b1", "b3", "c4", "e4", "f1", "f3" })]
    [DataRow('d', 3, new[] { "b2", "b4", "c1", "c5", "e1", "e5", "f2", "f4" })]
    [DataRow('d', 4, new[] { "b3", "b5", "c2", "c6", "e2", "e6", "f3", "f5" })]
    [DataRow('d', 5, new[] { "b4", "b6", "c3", "c7", "e3", "e7", "f4", "f6" })]
    [DataRow('d', 6, new[] { "b5", "b7", "c4", "c8", "e4", "e8", "f5", "f7" })]
    [DataRow('d', 7, new[] { "b6", "b8", "c5", "e5", "f6", "f8" })]
    [DataRow('d', 8, new[] { "b7", "c6", "e6", "f7" })]
    [DataRow('e', 1, new[] { "c2", "d3", "f3", "g2" })]
    [DataRow('e', 2, new[] { "c1", "c3", "d4", "f4", "g1", "g3" })]
    [DataRow('e', 3, new[] { "c2", "c4", "d1", "d5", "f1", "f5", "g2", "g4" })]
    [DataRow('e', 4, new[] { "c3", "c5", "d2", "d6", "f2", "f6", "g3", "g5" })]
    [DataRow('e', 5, new[] { "c4", "c6", "d3", "d7", "f3", "f7", "g4", "g6" })]
    [DataRow('e', 6, new[] { "c5", "c7", "d4", "d8", "f4", "f8", "g5", "g7" })]
    [DataRow('e', 7, new[] { "c6", "c8", "d5", "f5", "g6", "g8" })]
    [DataRow('e', 8, new[] { "c7", "d6", "f6", "g7" })]
    [DataRow('f', 1, new[] { "d2", "e3", "g3", "h2" })]
    [DataRow('f', 2, new[] { "d1", "d3", "e4", "g4", "h1", "h3" })]
    [DataRow('f', 3, new[] { "d2", "d4", "e1", "e5", "g1", "g5", "h2", "h4" })]
    [DataRow('f', 4, new[] { "d3", "d5", "e2", "e6", "g2", "g6", "h3", "h5" })]
    [DataRow('f', 5, new[] { "d4", "d6", "e3", "e7", "g3", "g7", "h4", "h6" })]
    [DataRow('f', 6, new[] { "d5", "d7", "e4", "e8", "g4", "g8", "h5", "h7" })]
    [DataRow('f', 7, new[] { "d6", "d8", "e5", "g5", "h6", "h8" })]
    [DataRow('f', 8, new[] { "d7", "e6", "g6", "h7" })]
    [DataRow('g', 1, new[] { "e2", "f3", "h3" })]
    [DataRow('g', 2, new[] { "e1", "e3", "f4", "h4" })]
    [DataRow('g', 3, new[] { "e2", "e4", "f1", "f5", "h1", "h5" })]
    [DataRow('g', 4, new[] { "e3", "e5", "f2", "f6", "h2", "h6" })]
    [DataRow('g', 5, new[] { "e4", "e6", "f3", "f7", "h3", "h7" })]
    [DataRow('g', 6, new[] { "e5", "e7", "f4", "f8", "h4", "h8" })]
    [DataRow('g', 7, new[] { "e6", "e8", "f5", "h5" })]
    [DataRow('g', 8, new[] { "e7", "f6", "h6" })]
    [DataRow('h', 1, new[] { "f2", "g3" })]
    [DataRow('h', 2, new[] { "f1", "f3", "g4" })]
    [DataRow('h', 3, new[] { "f2", "f4", "g1", "g5" })]
    [DataRow('h', 4, new[] { "f3", "f5", "g2", "g6" })]
    [DataRow('h', 5, new[] { "f4", "f6", "g3", "g7" })]
    [DataRow('h', 6, new[] { "f5", "f7", "g4", "g8" })]
    [DataRow('h', 7, new[] { "f6", "f8", "g5" })]
    [DataRow('h', 8, new[] { "f7", "g6" })]
    public void GetValidMoves_Knight_NoPossiblePositionsWhenAllSpacesTaken(char rank, int file, string[] expectedSquares)
    {
        var board = new Board();
        foreach (Piece.PieceColour colour in Enum.GetValues(typeof(Piece.PieceColour)))
        {
            var piece = new Knight(colour);
            board.GetSquare(rank, file).Piece = piece;

            for (int i = 0; i < expectedSquares.Length; i++)
            {
                var square = expectedSquares[i];
                var targetSquare = board.GetSquare((char)square[0], int.Parse(square[1].ToString()));
                targetSquare.Piece = new Pawn(colour);
            }

            var possibleMoves = piece.GetValidMoves(board);
            Assert.IsFalse(possibleMoves.Any(), "Expected no valid moves when all squares are occupied.");
        }
    }
}
