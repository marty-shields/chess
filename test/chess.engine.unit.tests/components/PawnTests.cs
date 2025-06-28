using chess.engine.components;

namespace chess.engine.unit.tests.components;

[TestClass]
public class PawnTests
{
    [DataTestMethod]
    [DataRow('a', 2)]
    [DataRow('b', 2)]
    [DataRow('c', 2)]
    [DataRow('d', 2)]
    [DataRow('e', 2)]
    [DataRow('f', 2)]
    [DataRow('g', 2)]
    [DataRow('h', 2)]
    public void GetValidMoves_Forward_WhitePawn_CanMoveForwardStartingPosition(char rank, int file)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.White);
        board.GetSquare(rank, file).Piece = piece;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(2, possibleMoves.Count(), "There should be 2 possible forward moves");

        var expectedMoves = new List<Square>()
        {
            board.GetSquare(rank, file + 1),
            board.GetSquare(rank, file + 2),
        };
        CollectionAssert.AreEquivalent(expectedMoves, possibleMoves.ToList());
    }

    [DataTestMethod]
    [DataRow('a', 7)]
    [DataRow('b', 7)]
    [DataRow('c', 7)]
    [DataRow('d', 7)]
    [DataRow('e', 7)]
    [DataRow('f', 7)]
    [DataRow('g', 7)]
    [DataRow('h', 7)]
    public void GetValidMoves_Forward_BlackPawn_CanMoveForwardStartingPosition(char rank, int file)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.Black);
        board.GetSquare(rank, file).Piece = piece;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(2, possibleMoves.Count(), "There should be 2 possible forward moves");

        var expectedMoves = new List<Square>()
        {
            board.GetSquare(rank, file - 1),
            board.GetSquare(rank, file - 2),
        };
        CollectionAssert.AreEquivalent(expectedMoves, possibleMoves.ToList());
    }

    [DataTestMethod]
    [DataRow('a', 3)]
    [DataRow('b', 3)]
    [DataRow('c', 3)]
    [DataRow('d', 3)]
    [DataRow('e', 3)]
    [DataRow('f', 3)]
    [DataRow('g', 3)]
    [DataRow('h', 3)]
    [DataRow('a', 4)]
    [DataRow('b', 4)]
    [DataRow('c', 4)]
    [DataRow('d', 4)]
    [DataRow('e', 4)]
    [DataRow('f', 4)]
    [DataRow('g', 4)]
    [DataRow('h', 4)]
    [DataRow('a', 5)]
    [DataRow('b', 5)]
    [DataRow('c', 5)]
    [DataRow('d', 5)]
    [DataRow('e', 5)]
    [DataRow('f', 5)]
    [DataRow('g', 5)]
    [DataRow('h', 5)]
    [DataRow('a', 6)]
    [DataRow('b', 6)]
    [DataRow('c', 6)]
    [DataRow('d', 6)]
    [DataRow('e', 6)]
    [DataRow('f', 6)]
    [DataRow('g', 6)]
    [DataRow('h', 6)]
    [DataRow('a', 7)]
    [DataRow('b', 7)]
    [DataRow('c', 7)]
    [DataRow('d', 7)]
    [DataRow('e', 7)]
    [DataRow('f', 7)]
    [DataRow('g', 7)]
    [DataRow('h', 7)]
    public void GetValidMoves_Forward_WhitePawn_CanOnlyMoveForward1Position_WhenNotInStartingPosition(char rank, int file)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.White);
        board.GetSquare(rank, file).Piece = piece;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(1, possibleMoves.Count(), "There should be 1 possible forward move");

        var expectedMoves = new List<Square>()
        {
            board.GetSquare(rank, file + 1)
        };
        CollectionAssert.AreEquivalent(expectedMoves, possibleMoves.ToList());
    }

    [DataTestMethod]
    [DataRow('a', 6)]
    [DataRow('b', 6)]
    [DataRow('c', 6)]
    [DataRow('d', 6)]
    [DataRow('e', 6)]
    [DataRow('f', 6)]
    [DataRow('g', 6)]
    [DataRow('h', 6)]
    [DataRow('a', 5)]
    [DataRow('b', 5)]
    [DataRow('c', 5)]
    [DataRow('d', 5)]
    [DataRow('e', 5)]
    [DataRow('f', 5)]
    [DataRow('g', 5)]
    [DataRow('h', 5)]
    [DataRow('a', 4)]
    [DataRow('b', 4)]
    [DataRow('c', 4)]
    [DataRow('d', 4)]
    [DataRow('e', 4)]
    [DataRow('f', 4)]
    [DataRow('g', 3)]
    [DataRow('h', 3)]
    [DataRow('a', 2)]
    [DataRow('b', 2)]
    [DataRow('c', 2)]
    [DataRow('d', 2)]
    [DataRow('e', 2)]
    [DataRow('f', 2)]
    [DataRow('g', 2)]
    [DataRow('h', 2)]
    public void GetValidMoves_Forward_BlackPawn_CanOnlyMoveForward1Position_WhenNotInStartingPosition(char rank, int file)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.Black);
        board.GetSquare(rank, file).Piece = piece;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(1, possibleMoves.Count(), "There should be 1 possible forward move");

        var expectedMoves = new List<Square>()
        {
            board.GetSquare(rank, file - 1)
        };
        CollectionAssert.AreEquivalent(expectedMoves, possibleMoves.ToList());
    }

    [DataTestMethod]
    [DataRow('a', 2)]
    [DataRow('b', 2)]
    [DataRow('c', 2)]
    [DataRow('d', 2)]
    [DataRow('e', 2)]
    [DataRow('f', 2)]
    [DataRow('g', 2)]
    [DataRow('h', 2)]
    public void GetValidMoves_Forward_WhitePawn_CanMoveForwardStartingPosition_Only1WhenOpponentIn2InFront(char rank, int file)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.White);
        var opponent = new Pawn(Piece.PieceColor.Black);
        board.GetSquare(rank, file).Piece = piece;
        board.GetSquare(rank, file + 2).Piece = opponent;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(1, possibleMoves.Count(), "There should be 1 possible forward move");

        var expectedMoves = new List<Square>()
        {
            board.GetSquare(rank, file + 1)
        };
        CollectionAssert.AreEquivalent(expectedMoves, possibleMoves.ToList());

        opponent = new Pawn(Piece.PieceColor.White);
        board.GetSquare(rank, file + 2).Piece = opponent;

        possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(1, possibleMoves.Count(), "There should be 1 possible forward move when own piece is in front");
        CollectionAssert.AreEquivalent(expectedMoves, possibleMoves.ToList());
    }

    [DataTestMethod]
    [DataRow('a', 7)]
    [DataRow('b', 7)]
    [DataRow('c', 7)]
    [DataRow('d', 7)]
    [DataRow('e', 7)]
    [DataRow('f', 7)]
    [DataRow('g', 7)]
    [DataRow('h', 7)]
    public void GetValidMoves_Forward_BlackPawn_CanMoveForwardStartingPosition_Only1WhenOpponentIn2InFront(char rank, int file)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.Black);
        var opponent = new Pawn(Piece.PieceColor.White);
        board.GetSquare(rank, file).Piece = piece;
        board.GetSquare(rank, file - 2).Piece = opponent;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(1, possibleMoves.Count(), "There should be 1 possible forward move");

        var expectedMoves = new List<Square>()
        {
            board.GetSquare(rank, file - 1)
        };
        CollectionAssert.AreEquivalent(expectedMoves, possibleMoves.ToList());

        opponent = new Pawn(Piece.PieceColor.Black);
        board.GetSquare(rank, file - 2).Piece = opponent;

        possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(1, possibleMoves.Count(), "There should be 1 possible forward move when own piece is in front");
        CollectionAssert.AreEquivalent(expectedMoves, possibleMoves.ToList());
    }

    [DataTestMethod]
    [DataRow('a', 1)]
    [DataRow('a', 2)]
    [DataRow('a', 3)]
    [DataRow('a', 4)]
    [DataRow('a', 5)]
    [DataRow('a', 6)]
    [DataRow('a', 7)]
    [DataRow('b', 1)]
    [DataRow('b', 2)]
    [DataRow('b', 3)]
    [DataRow('b', 4)]
    [DataRow('b', 5)]
    [DataRow('b', 6)]
    [DataRow('b', 7)]
    [DataRow('c', 1)]
    [DataRow('c', 2)]
    [DataRow('c', 3)]
    [DataRow('c', 4)]
    [DataRow('c', 5)]
    [DataRow('c', 6)]
    [DataRow('c', 7)]
    [DataRow('d', 1)]
    [DataRow('d', 2)]
    [DataRow('d', 3)]
    [DataRow('d', 4)]
    [DataRow('d', 5)]
    [DataRow('d', 6)]
    [DataRow('d', 7)]
    [DataRow('e', 1)]
    [DataRow('e', 2)]
    [DataRow('e', 3)]
    [DataRow('e', 4)]
    [DataRow('e', 5)]
    [DataRow('e', 6)]
    [DataRow('e', 7)]
    [DataRow('f', 1)]
    [DataRow('f', 2)]
    [DataRow('f', 3)]
    [DataRow('f', 4)]
    [DataRow('f', 5)]
    [DataRow('f', 6)]
    [DataRow('f', 7)]
    [DataRow('g', 1)]
    [DataRow('g', 2)]
    [DataRow('g', 3)]
    [DataRow('g', 4)]
    [DataRow('g', 5)]
    [DataRow('g', 6)]
    [DataRow('g', 7)]
    [DataRow('h', 1)]
    [DataRow('h', 2)]
    [DataRow('h', 3)]
    [DataRow('h', 4)]
    [DataRow('h', 5)]
    [DataRow('h', 6)]
    [DataRow('h', 7)]
    public void GetValidMoves_Forward_WhitePawn_CanNotMoveForwardWhenPieceInFront(char rank, int file)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.White);
        var opponent = new Pawn(Piece.PieceColor.Black);
        board.GetSquare(rank, file).Piece = piece;
        board.GetSquare(rank, file + 1).Piece = opponent;

        var possibleMoves = piece.GetValidMoves(board);
        Assert.AreEqual(0, possibleMoves.Count(), "There should be no possible forward move");

        opponent = new Pawn(Piece.PieceColor.White);
        board.GetSquare(rank, file + 1).Piece = opponent;

        possibleMoves = piece.GetValidMoves(board);
        Assert.AreEqual(0, possibleMoves.Count(), "There should be no possible forward move when own piece is in front");
    }

    [DataTestMethod]
    [DataRow('a', 7)]
    [DataRow('a', 6)]
    [DataRow('a', 5)]
    [DataRow('a', 4)]
    [DataRow('a', 3)]
    [DataRow('a', 2)]
    [DataRow('b', 7)]
    [DataRow('b', 6)]
    [DataRow('b', 5)]
    [DataRow('b', 4)]
    [DataRow('b', 3)]
    [DataRow('b', 2)]
    [DataRow('c', 7)]
    [DataRow('c', 6)]
    [DataRow('c', 5)]
    [DataRow('c', 4)]
    [DataRow('c', 3)]
    [DataRow('c', 2)]
    [DataRow('d', 7)]
    [DataRow('d', 6)]
    [DataRow('d', 5)]
    [DataRow('d', 4)]
    [DataRow('d', 3)]
    [DataRow('d', 2)]
    [DataRow('e', 7)]
    [DataRow('e', 6)]
    [DataRow('e', 5)]
    [DataRow('e', 4)]
    [DataRow('e', 3)]
    [DataRow('e', 2)]
    [DataRow('f', 7)]
    [DataRow('f', 6)]
    [DataRow('f', 5)]
    [DataRow('f', 4)]
    [DataRow('f', 3)]
    [DataRow('f', 2)]
    [DataRow('g', 7)]
    [DataRow('g', 6)]
    [DataRow('g', 5)]
    [DataRow('g', 4)]
    [DataRow('g', 3)]
    [DataRow('g', 2)]
    [DataRow('h', 7)]
    [DataRow('h', 6)]
    [DataRow('h', 5)]
    [DataRow('h', 4)]
    [DataRow('h', 3)]
    [DataRow('h', 2)]
    public void GetValidMoves_Forward_BlackPawn_CanNotMoveForwardWhenPieceInFront(char rank, int file)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.Black);
        var opponent = new Pawn(Piece.PieceColor.White);
        board.GetSquare(rank, file).Piece = piece;
        board.GetSquare(rank, file - 1).Piece = opponent;

        var possibleMoves = piece.GetValidMoves(board);
        Assert.AreEqual(0, possibleMoves.Count(), "There should be no possible forward move");

        opponent = new Pawn(Piece.PieceColor.Black);
        board.GetSquare(rank, file - 1).Piece = opponent;

        possibleMoves = piece.GetValidMoves(board);
        Assert.AreEqual(0, possibleMoves.Count(), "There should be no possible forward move when own piece is in front");
    }

    [DataTestMethod]
    [DataRow('a', 8)]
    [DataRow('b', 8)]
    [DataRow('c', 8)]
    [DataRow('d', 8)]
    [DataRow('e', 8)]
    [DataRow('f', 8)]
    [DataRow('g', 8)]
    [DataRow('h', 8)]
    public void GetValidMoves_Forward_WhitePawn_NoValidMovesAtTopOfBoard(char rank, int file)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.White);
        board.GetSquare(rank, file).Piece = piece;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(0, possibleMoves.Count(), "There should be no valid moves for a white pawn at the top of the board");
    }

    [DataTestMethod]
    [DataRow('a', 1)]
    [DataRow('b', 1)]
    [DataRow('c', 1)]
    [DataRow('d', 1)]
    [DataRow('e', 1)]
    [DataRow('f', 1)]
    [DataRow('g', 1)]
    [DataRow('h', 1)]
    public void GetValidMoves_Forward_BlackPawn_NoValidMovesAtBottomOfBoard(char rank, int file)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.Black);
        board.GetSquare(rank, file).Piece = piece;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(0, possibleMoves.Count(), "There should be no valid moves for a black pawn at the bottom of the board");
    }

    [DataTestMethod]
    [DataRow('a', 1)]
    [DataRow('a', 2)]
    [DataRow('a', 3)]
    [DataRow('a', 4)]
    [DataRow('a', 5)]
    [DataRow('a', 6)]
    [DataRow('a', 7)]
    public void GetValidMoves_WhitePawn_NoValidMovesOnLeftEdge_WhenOpponentInFront(char rank, int file)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.White);
        var opponent = new Pawn(Piece.PieceColor.Black);
        board.GetSquare(rank, file).Piece = piece;
        board.GetSquare(rank, file + 1).Piece = opponent;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(0, possibleMoves.Count(), "There should be no valid moves for a white pawn on the left edge with opponent in front");
    }

    [DataTestMethod]
    [DataRow('a', 7)]
    [DataRow('a', 6)]
    [DataRow('a', 5)]
    [DataRow('a', 4)]
    [DataRow('a', 3)]
    [DataRow('a', 2)]
    public void GetValidMoves_BlackPawn_NoValidMovesOnLeftEdge_WhenOpponentInFront(char rank, int file)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.Black);
        var opponent = new Pawn(Piece.PieceColor.White);
        board.GetSquare(rank, file).Piece = piece;
        board.GetSquare(rank, file - 1).Piece = opponent;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(0, possibleMoves.Count(), "There should be no valid moves for a black pawn on the left edge with opponent in front");
    }

    [DataTestMethod]
    [DataRow('h', 1)]
    [DataRow('h', 2)]
    [DataRow('h', 3)]
    [DataRow('h', 4)]
    [DataRow('h', 5)]
    [DataRow('h', 6)]
    [DataRow('h', 7)]
    public void GetValidMoves_WhitePawn_NoValidMovesOnRightEdge_WhenOpponentInFront(char rank, int file)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.White);
        var opponent = new Pawn(Piece.PieceColor.Black);
        board.GetSquare(rank, file).Piece = piece;
        board.GetSquare(rank, file + 1).Piece = opponent;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(0, possibleMoves.Count(), "There should be no valid moves for a white pawn on the right edge with opponent in front");
    }

    [DataTestMethod]
    [DataRow('h', 7)]
    [DataRow('h', 6)]
    [DataRow('h', 5)]
    [DataRow('h', 4)]
    [DataRow('h', 3)]
    [DataRow('h', 2)]
    public void GetValidMoves_BlackPawn_NoValidMovesOnRightEdge_WhenOpponentInFront(char rank, int file)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.Black);
        var opponent = new Pawn(Piece.PieceColor.White);
        board.GetSquare(rank, file).Piece = piece;
        board.GetSquare(rank, file - 1).Piece = opponent;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(0, possibleMoves.Count(), "There should be no valid moves for a black pawn on the right edge with opponent in front");
    }

    [DataTestMethod]
    [DataRow('b', 1)]
    [DataRow('c', 1)]
    [DataRow('d', 1)]
    [DataRow('e', 1)]
    [DataRow('f', 1)]
    [DataRow('g', 1)]
    [DataRow('h', 1)]
    [DataRow('b', 2)]
    [DataRow('c', 2)]
    [DataRow('d', 2)]
    [DataRow('e', 2)]
    [DataRow('f', 2)]
    [DataRow('g', 2)]
    [DataRow('h', 2)]
    [DataRow('b', 3)]
    [DataRow('c', 3)]
    [DataRow('d', 3)]
    [DataRow('e', 3)]
    [DataRow('f', 3)]
    [DataRow('g', 3)]
    [DataRow('h', 3)]
    [DataRow('b', 4)]
    [DataRow('c', 4)]
    [DataRow('d', 4)]
    [DataRow('e', 4)]
    [DataRow('f', 4)]
    [DataRow('g', 4)]
    [DataRow('h', 4)]
    [DataRow('b', 5)]
    [DataRow('c', 5)]
    [DataRow('d', 5)]
    [DataRow('e', 5)]
    [DataRow('f', 5)]
    [DataRow('g', 5)]
    [DataRow('h', 5)]
    [DataRow('b', 6)]
    [DataRow('c', 6)]
    [DataRow('d', 6)]
    [DataRow('e', 6)]
    [DataRow('f', 6)]
    [DataRow('g', 6)]
    [DataRow('h', 6)]
    [DataRow('b', 7)]
    [DataRow('c', 7)]
    [DataRow('d', 7)]
    [DataRow('e', 7)]
    [DataRow('f', 7)]
    [DataRow('g', 7)]
    [DataRow('h', 7)]
    public void GetValidMoves_DiagLeft_WhitePawn_CanCaptureOpponent(char rank, int file)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.White);
        var opponent = new Pawn(Piece.PieceColor.Black);
        var opponent2 = new Pawn(Piece.PieceColor.White);
        char captureRank = (char)(rank - 1);
        board.GetSquare(rank, file).Piece = piece;
        board.GetSquare(captureRank, file + 1).Piece = opponent;
        board.GetSquare(rank, file + 1).Piece = opponent2;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(1, possibleMoves.Count(), "There should be 1 valid diagonal capture move");

        var expectedMoves = new List<Square>()
        {
            board.GetSquare(captureRank, file + 1)
        };
        CollectionAssert.AreEquivalent(expectedMoves, possibleMoves.ToList());
    }

    [DataTestMethod]
    [DataRow('a', 1)]
    [DataRow('b', 1)]
    [DataRow('c', 1)]
    [DataRow('d', 1)]
    [DataRow('e', 1)]
    [DataRow('f', 1)]
    [DataRow('g', 1)]
    [DataRow('a', 2)]
    [DataRow('b', 2)]
    [DataRow('c', 2)]
    [DataRow('d', 2)]
    [DataRow('e', 2)]
    [DataRow('f', 2)]
    [DataRow('g', 2)]
    [DataRow('a', 3)]
    [DataRow('b', 3)]
    [DataRow('c', 3)]
    [DataRow('d', 3)]
    [DataRow('e', 3)]
    [DataRow('f', 3)]
    [DataRow('g', 3)]
    [DataRow('a', 4)]
    [DataRow('b', 4)]
    [DataRow('c', 4)]
    [DataRow('d', 4)]
    [DataRow('e', 4)]
    [DataRow('f', 4)]
    [DataRow('g', 4)]
    [DataRow('a', 5)]
    [DataRow('b', 5)]
    [DataRow('c', 5)]
    [DataRow('d', 5)]
    [DataRow('e', 5)]
    [DataRow('f', 5)]
    [DataRow('g', 5)]
    [DataRow('a', 6)]
    [DataRow('b', 6)]
    [DataRow('c', 6)]
    [DataRow('d', 6)]
    [DataRow('e', 6)]
    [DataRow('f', 6)]
    [DataRow('g', 6)]
    [DataRow('a', 7)]
    [DataRow('b', 7)]
    [DataRow('c', 7)]
    [DataRow('d', 7)]
    [DataRow('e', 7)]
    [DataRow('f', 7)]
    [DataRow('g', 7)]
    public void GetValidMoves_DiagRight_WhitePawn_CanCaptureOpponent(char rank, int file)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.White);
        var opponent = new Pawn(Piece.PieceColor.Black);
        var opponent2 = new Pawn(Piece.PieceColor.White);
        char captureRank = (char)(rank + 1);
        board.GetSquare(rank, file).Piece = piece;
        board.GetSquare(captureRank, file + 1).Piece = opponent;
        board.GetSquare(rank, file + 1).Piece = opponent2;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(1, possibleMoves.Count(), "There should be 1 valid diagonal capture move");

        var expectedMoves = new List<Square>()
        {
            board.GetSquare(captureRank, file + 1)
        };
        CollectionAssert.AreEquivalent(expectedMoves, possibleMoves.ToList());
    }

    [DataTestMethod]
    [DataRow('h', 7)]
    [DataRow('g', 7)]
    [DataRow('f', 7)]
    [DataRow('e', 7)]
    [DataRow('d', 7)]
    [DataRow('c', 7)]
    [DataRow('b', 7)]
    [DataRow('h', 6)]
    [DataRow('g', 6)]
    [DataRow('f', 6)]
    [DataRow('e', 6)]
    [DataRow('d', 6)]
    [DataRow('c', 6)]
    [DataRow('b', 6)]
    [DataRow('h', 5)]
    [DataRow('g', 5)]
    [DataRow('f', 5)]
    [DataRow('e', 5)]
    [DataRow('d', 5)]
    [DataRow('c', 5)]
    [DataRow('b', 5)]
    [DataRow('h', 4)]
    [DataRow('g', 4)]
    [DataRow('f', 4)]
    [DataRow('e', 4)]
    [DataRow('d', 4)]
    [DataRow('c', 4)]
    [DataRow('b', 4)]
    [DataRow('h', 3)]
    [DataRow('g', 3)]
    [DataRow('f', 3)]
    [DataRow('e', 3)]
    [DataRow('d', 3)]
    [DataRow('c', 3)]
    [DataRow('b', 3)]
    [DataRow('h', 2)]
    [DataRow('g', 2)]
    [DataRow('f', 2)]
    [DataRow('e', 2)]
    [DataRow('d', 2)]
    [DataRow('c', 2)]
    [DataRow('b', 2)]
    public void GetValidMoves_DiagLeft_BlackPawn_CanCaptureOpponent(char rank, int file)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.Black);
        var opponent = new Pawn(Piece.PieceColor.White);
        var opponent2 = new Pawn(Piece.PieceColor.Black);
        char captureRank = (char)(rank - 1);
        board.GetSquare(rank, file).Piece = piece;
        board.GetSquare(captureRank, file - 1).Piece = opponent;
        board.GetSquare(rank, file - 1).Piece = opponent2;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(1, possibleMoves.Count(), "There should be 1 valid diagonal capture move");

        var expectedMoves = new List<Square>()
        {
            board.GetSquare(captureRank, file - 1)
        };
        CollectionAssert.AreEquivalent(expectedMoves, possibleMoves.ToList());
    }

    [DataTestMethod]
    [DataRow('a', 7)]
    [DataRow('b', 7)]
    [DataRow('c', 7)]
    [DataRow('d', 7)]
    [DataRow('e', 7)]
    [DataRow('f', 7)]
    [DataRow('g', 7)]
    [DataRow('a', 6)]
    [DataRow('b', 6)]
    [DataRow('c', 6)]
    [DataRow('d', 6)]
    [DataRow('e', 6)]
    [DataRow('f', 6)]
    [DataRow('g', 6)]
    [DataRow('a', 5)]
    [DataRow('b', 5)]
    [DataRow('c', 5)]
    [DataRow('d', 5)]
    [DataRow('e', 5)]
    [DataRow('f', 5)]
    [DataRow('g', 5)]
    [DataRow('a', 4)]
    [DataRow('b', 4)]
    [DataRow('c', 4)]
    [DataRow('d', 4)]
    [DataRow('e', 4)]
    [DataRow('f', 4)]
    [DataRow('g', 4)]
    [DataRow('a', 3)]
    [DataRow('b', 3)]
    [DataRow('c', 3)]
    [DataRow('d', 3)]
    [DataRow('e', 3)]
    [DataRow('f', 3)]
    [DataRow('g', 3)]
    [DataRow('a', 2)]
    [DataRow('b', 2)]
    [DataRow('c', 2)]
    [DataRow('d', 2)]
    [DataRow('e', 2)]
    [DataRow('f', 2)]
    [DataRow('g', 2)]
    public void GetValidMoves_DiagRight_BlackPawn_CanCaptureOpponent(char rank, int file)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.Black);
        var opponent = new Pawn(Piece.PieceColor.White);
        var opponent2 = new Pawn(Piece.PieceColor.Black);
        char captureRank = (char)(rank + 1);
        board.GetSquare(rank, file).Piece = piece;
        board.GetSquare(captureRank, file - 1).Piece = opponent;
        board.GetSquare(rank, file - 1).Piece = opponent2;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(1, possibleMoves.Count(), "There should be 1 valid diagonal capture move");

        var expectedMoves = new List<Square>()
        {
            board.GetSquare(captureRank, file - 1)
        };
        CollectionAssert.AreEquivalent(expectedMoves, possibleMoves.ToList());
    }

    [DataTestMethod]
    [DataRow('b', 1)]
    [DataRow('c', 1)]
    [DataRow('d', 1)]
    [DataRow('e', 1)]
    [DataRow('f', 1)]
    [DataRow('g', 1)]
    [DataRow('h', 1)]
    [DataRow('b', 2)]
    [DataRow('c', 2)]
    [DataRow('d', 2)]
    [DataRow('e', 2)]
    [DataRow('f', 2)]
    [DataRow('g', 2)]
    [DataRow('h', 2)]
    [DataRow('b', 3)]
    [DataRow('c', 3)]
    [DataRow('d', 3)]
    [DataRow('e', 3)]
    [DataRow('f', 3)]
    [DataRow('g', 3)]
    [DataRow('h', 3)]
    [DataRow('b', 4)]
    [DataRow('c', 4)]
    [DataRow('d', 4)]
    [DataRow('e', 4)]
    [DataRow('f', 4)]
    [DataRow('g', 4)]
    [DataRow('h', 4)]
    [DataRow('b', 5)]
    [DataRow('c', 5)]
    [DataRow('d', 5)]
    [DataRow('e', 5)]
    [DataRow('f', 5)]
    [DataRow('g', 5)]
    [DataRow('h', 5)]
    [DataRow('b', 6)]
    [DataRow('c', 6)]
    [DataRow('d', 6)]
    [DataRow('e', 6)]
    [DataRow('f', 6)]
    [DataRow('g', 6)]
    [DataRow('h', 6)]
    [DataRow('b', 7)]
    [DataRow('c', 7)]
    [DataRow('d', 7)]
    [DataRow('e', 7)]
    [DataRow('f', 7)]
    [DataRow('g', 7)]
    [DataRow('h', 7)]
    public void GetValidMoves_DiagLeft_WhitePawn_CannotCaptureOwnPiece(char rank, int file)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.White);
        var ownPiece = new Pawn(Piece.PieceColor.White);
        var opponent2 = new Pawn(Piece.PieceColor.Black);
        char captureRank = (char)(rank - 1);
        board.GetSquare(rank, file).Piece = piece;
        board.GetSquare(captureRank, file + 1).Piece = ownPiece;
        board.GetSquare(rank, file + 1).Piece = opponent2;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(0, possibleMoves.Count(), "There should be no valid diagonal capture move for a white pawn capturing its own piece");
    }

    [DataTestMethod]
    [DataRow('a', 1)]
    [DataRow('b', 1)]
    [DataRow('c', 1)]
    [DataRow('d', 1)]
    [DataRow('e', 1)]
    [DataRow('f', 1)]
    [DataRow('g', 1)]
    [DataRow('a', 2)]
    [DataRow('b', 2)]
    [DataRow('c', 2)]
    [DataRow('d', 2)]
    [DataRow('e', 2)]
    [DataRow('f', 2)]
    [DataRow('g', 2)]
    [DataRow('a', 3)]
    [DataRow('b', 3)]
    [DataRow('c', 3)]
    [DataRow('d', 3)]
    [DataRow('e', 3)]
    [DataRow('f', 3)]
    [DataRow('g', 3)]
    [DataRow('a', 4)]
    [DataRow('b', 4)]
    [DataRow('c', 4)]
    [DataRow('d', 4)]
    [DataRow('e', 4)]
    [DataRow('f', 4)]
    [DataRow('g', 4)]
    [DataRow('a', 5)]
    [DataRow('b', 5)]
    [DataRow('c', 5)]
    [DataRow('d', 5)]
    [DataRow('e', 5)]
    [DataRow('f', 5)]
    [DataRow('g', 5)]
    [DataRow('a', 6)]
    [DataRow('b', 6)]
    [DataRow('c', 6)]
    [DataRow('d', 6)]
    [DataRow('e', 6)]
    [DataRow('f', 6)]
    [DataRow('g', 6)]
    [DataRow('a', 7)]
    [DataRow('b', 7)]
    [DataRow('c', 7)]
    [DataRow('d', 7)]
    [DataRow('e', 7)]
    [DataRow('f', 7)]
    [DataRow('g', 7)]
    public void GetValidMoves_DiagRight_WhitePawn_CannotCaptureOwnPiece(char rank, int file)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.White);
        var ownPiece = new Pawn(Piece.PieceColor.White);
        var opponent2 = new Pawn(Piece.PieceColor.Black);
        char captureRank = (char)(rank + 1);
        board.GetSquare(rank, file).Piece = piece;
        board.GetSquare(captureRank, file + 1).Piece = ownPiece;
        board.GetSquare(rank, file + 1).Piece = opponent2;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(0, possibleMoves.Count(), "There should be no valid diagonal capture move for a white pawn capturing its own piece");
    }

    [DataTestMethod]
    [DataRow('b', 7)]
    [DataRow('c', 7)]
    [DataRow('d', 7)]
    [DataRow('e', 7)]
    [DataRow('f', 7)]
    [DataRow('g', 7)]
    [DataRow('h', 7)]
    [DataRow('b', 6)]
    [DataRow('c', 6)]
    [DataRow('d', 6)]
    [DataRow('e', 6)]
    [DataRow('f', 6)]
    [DataRow('g', 6)]
    [DataRow('h', 6)]
    [DataRow('b', 5)]
    [DataRow('c', 5)]
    [DataRow('d', 5)]
    [DataRow('e', 5)]
    [DataRow('f', 5)]
    [DataRow('g', 5)]
    [DataRow('h', 5)]
    [DataRow('b', 4)]
    [DataRow('c', 4)]
    [DataRow('d', 4)]
    [DataRow('e', 4)]
    [DataRow('f', 4)]
    [DataRow('g', 4)]
    [DataRow('h', 4)]
    [DataRow('b', 3)]
    [DataRow('c', 3)]
    [DataRow('d', 3)]
    [DataRow('e', 3)]
    [DataRow('f', 3)]
    [DataRow('g', 3)]
    [DataRow('h', 3)]
    [DataRow('b', 2)]
    [DataRow('c', 2)]
    [DataRow('d', 2)]
    [DataRow('e', 2)]
    [DataRow('f', 2)]
    [DataRow('g', 2)]
    [DataRow('h', 2)]
    public void GetValidMoves_DiagLeft_BlackPawn_CannotCaptureOwnPiece(char rank, int file)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.Black);
        var ownPiece = new Pawn(Piece.PieceColor.Black);
        var opponent2 = new Pawn(Piece.PieceColor.White);
        char captureRank = (char)(rank - 1);
        board.GetSquare(rank, file).Piece = piece;
        board.GetSquare(captureRank, file - 1).Piece = ownPiece;
        board.GetSquare(rank, file - 1).Piece = opponent2;

        var possibleMoves = piece.GetValidMoves(board);
        Assert.AreEqual(0, possibleMoves.Count(), "There should be no valid diagonal capture move for a black pawn capturing its own piece");
    }

    [DataTestMethod]
    [DataRow('a', 7)]
    [DataRow('b', 7)]
    [DataRow('c', 7)]
    [DataRow('d', 7)]
    [DataRow('e', 7)]
    [DataRow('f', 7)]
    [DataRow('g', 7)]
    [DataRow('a', 6)]
    [DataRow('b', 6)]
    [DataRow('c', 6)]
    [DataRow('d', 6)]
    [DataRow('e', 6)]
    [DataRow('f', 6)]
    [DataRow('g', 6)]
    [DataRow('a', 5)]
    [DataRow('b', 5)]
    [DataRow('c', 5)]
    [DataRow('d', 5)]
    [DataRow('e', 5)]
    [DataRow('f', 5)]
    [DataRow('g', 5)]
    [DataRow('a', 4)]
    [DataRow('b', 4)]
    [DataRow('c', 4)]
    [DataRow('d', 4)]
    [DataRow('e', 4)]
    [DataRow('f', 4)]
    [DataRow('g', 4)]
    [DataRow('a', 3)]
    [DataRow('b', 3)]
    [DataRow('c', 3)]
    [DataRow('d', 3)]
    [DataRow('e', 3)]
    [DataRow('f', 3)]
    [DataRow('g', 3)]
    [DataRow('a', 2)]
    [DataRow('b', 2)]
    [DataRow('c', 2)]
    [DataRow('d', 2)]
    [DataRow('e', 2)]
    [DataRow('f', 2)]
    [DataRow('g', 2)]
    public void GetValidMoves_DiagRight_BlackPawn_CannotCaptureOwnPiece(char rank, int file)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.Black);
        var ownPiece = new Pawn(Piece.PieceColor.Black);
        var opponent2 = new Pawn(Piece.PieceColor.White);
        char captureRank = (char)(rank + 1);
        board.GetSquare(rank, file).Piece = piece;
        board.GetSquare(captureRank, file - 1).Piece = ownPiece;
        board.GetSquare(rank, file - 1).Piece = opponent2;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(0, possibleMoves.Count(), "There should be no valid diagonal capture move for a black pawn capturing its own piece");
    }
}