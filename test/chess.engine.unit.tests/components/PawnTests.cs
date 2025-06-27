using chess.engine.components;

namespace chess.engine.unit.tests.components;

[TestClass]
public class PawnTests
{
    [DataTestMethod]
    [DataRow(0, 1)]
    [DataRow(1, 1)]
    [DataRow(2, 1)]
    [DataRow(3, 1)]
    [DataRow(4, 1)]
    [DataRow(5, 1)]
    [DataRow(6, 1)]
    [DataRow(7, 1)]
    public void GetValidMoves_Forward_WhitePawn_CanMoveForwardStartingPosition(int posX, int posY)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.White);
        board._squares[posX, posY] = new Square();
        board._squares[posX, posY].Piece = piece;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(2, possibleMoves.Count(), "There should be 2 possible forward moves");

        var expectedMoves = new List<(int, int)>()
        {
            (posX, posY + 1),
            (posX, posY + 2),
        };
        CollectionAssert.AreEquivalent(expectedMoves, possibleMoves.ToList());
    }

    [DataTestMethod]
    [DataRow(0, 6)]
    [DataRow(1, 6)]
    [DataRow(2, 6)]
    [DataRow(3, 6)]
    [DataRow(4, 6)]
    [DataRow(5, 6)]
    [DataRow(6, 6)]
    [DataRow(7, 6)]
    public void GetValidMoves_Forward_BlackPawn_CanMoveForwardStartingPosition(int posX, int posY)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.Black);
        board._squares[posX, posY] = new Square();
        board._squares[posX, posY].Piece = piece;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(2, possibleMoves.Count(), "There should be 2 possible forward moves");

        var expectedMoves = new List<(int, int)>()
        {
            (posX, posY - 1),
            (posX, posY - 2),
        };
        CollectionAssert.AreEquivalent(expectedMoves, possibleMoves.ToList());
    }

    [DataTestMethod]
    [DataRow(0, 2)]
    [DataRow(1, 2)]
    [DataRow(2, 2)]
    [DataRow(3, 2)]
    [DataRow(4, 2)]
    [DataRow(5, 2)]
    [DataRow(6, 2)]
    [DataRow(7, 2)]
    [DataRow(0, 3)]
    [DataRow(1, 3)]
    [DataRow(2, 3)]
    [DataRow(3, 3)]
    [DataRow(4, 3)]
    [DataRow(5, 3)]
    [DataRow(6, 3)]
    [DataRow(7, 3)]
    [DataRow(0, 4)]
    [DataRow(1, 4)]
    [DataRow(2, 4)]
    [DataRow(3, 4)]
    [DataRow(4, 4)]
    [DataRow(5, 4)]
    [DataRow(6, 4)]
    [DataRow(7, 4)]
    [DataRow(0, 5)]
    [DataRow(1, 5)]
    [DataRow(2, 5)]
    [DataRow(3, 5)]
    [DataRow(4, 5)]
    [DataRow(5, 5)]
    [DataRow(6, 5)]
    [DataRow(7, 5)]
    [DataRow(0, 6)]
    [DataRow(1, 6)]
    [DataRow(2, 6)]
    [DataRow(3, 6)]
    [DataRow(4, 6)]
    [DataRow(5, 6)]
    [DataRow(6, 6)]
    [DataRow(7, 6)]
    public void GetValidMoves_Forward_WhitePawn_CanOnlyMoveForward1Position_WhenNotInStartingPosition(int posX, int posY)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.White);
        board._squares[posX, posY] = new Square();
        board._squares[posX, posY].Piece = piece;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(1, possibleMoves.Count(), "There should be 1 possible forward move");

        var expectedMoves = new List<(int, int)>()
        {
            (posX, posY + 1),
        };
        CollectionAssert.AreEquivalent(expectedMoves, possibleMoves.ToList());
    }

    [DataTestMethod]
    [DataRow(0, 5)]
    [DataRow(1, 5)]
    [DataRow(2, 5)]
    [DataRow(3, 5)]
    [DataRow(4, 5)]
    [DataRow(5, 5)]
    [DataRow(6, 5)]
    [DataRow(7, 5)]
    [DataRow(0, 4)]
    [DataRow(1, 4)]
    [DataRow(2, 4)]
    [DataRow(3, 4)]
    [DataRow(4, 4)]
    [DataRow(5, 4)]
    [DataRow(6, 4)]
    [DataRow(7, 4)]
    [DataRow(0, 3)]
    [DataRow(1, 3)]
    [DataRow(2, 3)]
    [DataRow(3, 3)]
    [DataRow(4, 3)]
    [DataRow(5, 3)]
    [DataRow(6, 3)]
    [DataRow(7, 3)]
    [DataRow(0, 2)]
    [DataRow(1, 2)]
    [DataRow(2, 2)]
    [DataRow(3, 2)]
    [DataRow(4, 2)]
    [DataRow(5, 2)]
    [DataRow(6, 2)]
    [DataRow(7, 2)]
    [DataRow(0, 1)]
    [DataRow(1, 1)]
    [DataRow(2, 1)]
    [DataRow(3, 1)]
    [DataRow(4, 1)]
    [DataRow(5, 1)]
    [DataRow(6, 1)]
    [DataRow(7, 1)]
    public void GetValidMoves_Forward_BlackPawn_CanOnlyMoveForward1Position_WhenNotInStartingPosition(int posX, int posY)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.Black);
        board._squares[posX, posY] = new Square();
        board._squares[posX, posY].Piece = piece;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(1, possibleMoves.Count(), "There should be 1 possible forward move");

        var expectedMoves = new List<(int, int)>()
        {
            (posX, posY - 1),
        };
        CollectionAssert.AreEquivalent(expectedMoves, possibleMoves.ToList());
    }

    [DataTestMethod]
    [DataRow(0, 1)]
    [DataRow(1, 1)]
    [DataRow(2, 1)]
    [DataRow(3, 1)]
    [DataRow(4, 1)]
    [DataRow(5, 1)]
    [DataRow(6, 1)]
    [DataRow(7, 1)]
    public void GetValidMoves_Forward_WhitePawn_CanMoveForwardStartingPosition_Only1WhenOpponentIn2InFront(int posX, int posY)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.White);
        var opponent = new Pawn(Piece.PieceColor.Black);
        board._squares[posX, posY] = new Square();
        board._squares[posX, posY].Piece = piece;
        board._squares[posX, posY + 2] = new Square();
        board._squares[posX, posY + 2].Piece = opponent;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(1, possibleMoves.Count(), "There should be 1 possible forward move");

        var expectedMoves = new List<(int, int)>()
        {
            (posX, posY + 1),
        };
        CollectionAssert.AreEquivalent(expectedMoves, possibleMoves.ToList());

        opponent = new Pawn(Piece.PieceColor.White);
        board._squares[posX, posY + 2].Piece = opponent;

        possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(1, possibleMoves.Count(), "There should be 1 possible forward move when own piece is in front");
        CollectionAssert.AreEquivalent(expectedMoves, possibleMoves.ToList());
    }

    [DataTestMethod]
    [DataRow(0, 6)]
    [DataRow(1, 6)]
    [DataRow(2, 6)]
    [DataRow(3, 6)]
    [DataRow(4, 6)]
    [DataRow(5, 6)]
    [DataRow(6, 6)]
    [DataRow(7, 6)]
    public void GetValidMoves_Forward_BlackPawn_CanMoveForwardStartingPosition_Only1WhenOpponentIn2InFront(int posX, int posY)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.Black);
        var opponent = new Pawn(Piece.PieceColor.White);
        board._squares[posX, posY] = new Square();
        board._squares[posX, posY].Piece = piece;
        board._squares[posX, posY - 2] = new Square();
        board._squares[posX, posY - 2].Piece = opponent;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(1, possibleMoves.Count(), "There should be 1 possible forward move");

        var expectedMoves = new List<(int, int)>()
        {
            (posX, posY - 1),
        };
        CollectionAssert.AreEquivalent(expectedMoves, possibleMoves.ToList());

        opponent = new Pawn(Piece.PieceColor.Black);
        board._squares[posX, posY - 2].Piece = opponent;

        possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(1, possibleMoves.Count(), "There should be 1 possible forward move when own piece is in front");
        CollectionAssert.AreEquivalent(expectedMoves, possibleMoves.ToList());
    }

    [DataTestMethod]
    [DataRow(1, 0)]
    [DataRow(1, 1)]
    [DataRow(1, 2)]
    [DataRow(1, 3)]
    [DataRow(1, 4)]
    [DataRow(1, 5)]
    [DataRow(1, 6)]
    [DataRow(2, 0)]
    [DataRow(2, 1)]
    [DataRow(2, 2)]
    [DataRow(2, 3)]
    [DataRow(2, 4)]
    [DataRow(2, 5)]
    [DataRow(2, 6)]
    [DataRow(3, 0)]
    [DataRow(3, 1)]
    [DataRow(3, 2)]
    [DataRow(3, 3)]
    [DataRow(3, 4)]
    [DataRow(3, 5)]
    [DataRow(3, 6)]
    [DataRow(4, 0)]
    [DataRow(4, 1)]
    [DataRow(4, 2)]
    [DataRow(4, 3)]
    [DataRow(4, 4)]
    [DataRow(4, 5)]
    [DataRow(4, 6)]
    [DataRow(5, 0)]
    [DataRow(5, 1)]
    [DataRow(5, 2)]
    [DataRow(5, 3)]
    [DataRow(5, 4)]
    [DataRow(5, 5)]
    [DataRow(5, 6)]
    [DataRow(6, 0)]
    [DataRow(6, 1)]
    [DataRow(6, 2)]
    [DataRow(6, 3)]
    [DataRow(6, 4)]
    [DataRow(6, 5)]
    [DataRow(6, 6)]
    public void GetValidMoves_Forward_WhitePawn_CanNotMoveForwardWhenPieceInFront(int posX, int posY)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.White);
        var opponent = new Pawn(Piece.PieceColor.Black);
        board._squares[posX, posY] = new Square();
        board._squares[posX, posY].Piece = piece;
        board._squares[posX, posY + 1] = new Square();
        board._squares[posX, posY + 1].Piece = opponent;

        var possibleMoves = piece.GetValidMoves(board);
        Assert.AreEqual(0, possibleMoves.Count(), "There should be no possible forward move");

        opponent = new Pawn(Piece.PieceColor.White);
        board._squares[posX, posY + 1].Piece = opponent;

        possibleMoves = piece.GetValidMoves(board);
        Assert.AreEqual(0, possibleMoves.Count(), "There should be no possible forward move when own piece is in front");
    }

    [DataTestMethod]
    [DataRow(1, 7)]
    [DataRow(1, 6)]
    [DataRow(1, 5)]
    [DataRow(1, 4)]
    [DataRow(1, 3)]
    [DataRow(1, 2)]
    [DataRow(1, 1)]
    [DataRow(2, 7)]
    [DataRow(2, 6)]
    [DataRow(2, 5)]
    [DataRow(2, 4)]
    [DataRow(2, 3)]
    [DataRow(2, 2)]
    [DataRow(2, 1)]
    [DataRow(3, 7)]
    [DataRow(3, 6)]
    [DataRow(3, 5)]
    [DataRow(3, 4)]
    [DataRow(3, 3)]
    [DataRow(3, 2)]
    [DataRow(3, 1)]
    [DataRow(4, 7)]
    [DataRow(4, 6)]
    [DataRow(4, 5)]
    [DataRow(4, 4)]
    [DataRow(4, 3)]
    [DataRow(4, 2)]
    [DataRow(4, 1)]
    [DataRow(5, 7)]
    [DataRow(5, 6)]
    [DataRow(5, 5)]
    [DataRow(5, 4)]
    [DataRow(5, 3)]
    [DataRow(5, 2)]
    [DataRow(5, 1)]
    [DataRow(6, 7)]
    [DataRow(6, 6)]
    [DataRow(6, 5)]
    [DataRow(6, 4)]
    [DataRow(6, 3)]
    [DataRow(6, 2)]
    [DataRow(6, 1)]
    public void GetValidMoves_Forward_BlackPawn_CanNotMoveForwardWhenPieceInFront(int posX, int posY)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.Black);
        var opponent = new Pawn(Piece.PieceColor.White);
        board._squares[posX, posY] = new Square();
        board._squares[posX, posY].Piece = piece;
        board._squares[posX, posY - 1] = new Square();
        board._squares[posX, posY - 1].Piece = opponent;

        var possibleMoves = piece.GetValidMoves(board);
        Assert.AreEqual(0, possibleMoves.Count(), "There should be no possible forward move");

        opponent = new Pawn(Piece.PieceColor.Black);
        board._squares[posX, posY - 1].Piece = opponent;

        possibleMoves = piece.GetValidMoves(board);
        Assert.AreEqual(0, possibleMoves.Count(), "There should be no possible forward move when own piece is in front");
    }

    [DataTestMethod]
    [DataRow(0, 7)]
    [DataRow(1, 7)]
    [DataRow(2, 7)]
    [DataRow(3, 7)]
    [DataRow(4, 7)]
    [DataRow(5, 7)]
    [DataRow(6, 7)]
    [DataRow(7, 7)]
    public void GetValidMoves_Forward_WhitePawn_NoValidMovesAtTopOfBoard(int posX, int posY)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.White);
        board._squares[posX, posY] = new Square();
        board._squares[posX, posY].Piece = piece;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(0, possibleMoves.Count(), "There should be no valid moves for a white pawn at the top of the board");
    }

    [DataTestMethod]
    [DataRow(0, 1)]
    [DataRow(0, 2)]
    [DataRow(0, 3)]
    [DataRow(0, 4)]
    [DataRow(0, 5)]
    [DataRow(0, 6)]
    public void GetValidMoves_WhitePawn_NoValidMovesOnLeftEdge_WhenOpponentInFront(int posX, int posY)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.White);
        var opponent = new Pawn(Piece.PieceColor.Black);
        board._squares[posX, posY] = new Square();
        board._squares[posX, posY].Piece = piece;
        board._squares[posX, posY + 1] = new Square();
        board._squares[posX, posY + 1].Piece = opponent;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(0, possibleMoves.Count(), "There should be no valid moves for a white pawn on the left edge with opponent in front");
    }

    [DataTestMethod]
    [DataRow(0, 6)]
    [DataRow(0, 5)]
    [DataRow(0, 4)]
    [DataRow(0, 3)]
    [DataRow(0, 2)]
    [DataRow(0, 1)]
    public void GetValidMoves_BlackPawn_NoValidMovesOnLeftEdge_WhenOpponentInFront(int posX, int posY)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.Black);
        var opponent = new Pawn(Piece.PieceColor.White);
        board._squares[posX, posY] = new Square();
        board._squares[posX, posY].Piece = piece;
        board._squares[posX, posY - 1] = new Square();
        board._squares[posX, posY - 1].Piece = opponent;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(0, possibleMoves.Count(), "There should be no valid moves for a black pawn on the left edge with opponent in front");
    }

    [DataTestMethod]
    [DataRow(7, 1)]
    [DataRow(7, 2)]
    [DataRow(7, 3)]
    [DataRow(7, 4)]
    [DataRow(7, 5)]
    [DataRow(7, 6)]
    public void GetValidMoves_WhitePawn_NoValidMovesOnRightEdge_WhenOpponentInFront(int posX, int posY)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.White);
        var opponent = new Pawn(Piece.PieceColor.Black);
        board._squares[posX, posY] = new Square();
        board._squares[posX, posY].Piece = piece;
        board._squares[posX, posY + 1] = new Square();
        board._squares[posX, posY + 1].Piece = opponent;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(0, possibleMoves.Count(), "There should be no valid moves for a white pawn on the right edge with opponent in front");
    }

    [DataTestMethod]
    [DataRow(7, 6)]
    [DataRow(7, 5)]
    [DataRow(7, 4)]
    [DataRow(7, 3)]
    [DataRow(7, 2)]
    [DataRow(7, 1)]
    public void GetValidMoves_BlackPawn_NoValidMovesOnRightEdge_WhenOpponentInFront(int posX, int posY)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.Black);
        var opponent = new Pawn(Piece.PieceColor.White);
        board._squares[posX, posY] = new Square();
        board._squares[posX, posY].Piece = piece;
        board._squares[posX, posY - 1] = new Square();
        board._squares[posX, posY - 1].Piece = opponent;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(0, possibleMoves.Count(), "There should be no valid moves for a black pawn on the right edge with opponent in front");
    }

    [DataTestMethod]
    [DataRow(0, 0)]
    [DataRow(1, 0)]
    [DataRow(2, 0)]
    [DataRow(3, 0)]
    [DataRow(4, 0)]
    [DataRow(5, 0)]
    [DataRow(6, 0)]
    [DataRow(7, 0)]
    public void GetValidMoves_Forward_BlackPawn_NoValidMovesAtBottomOfBoard(int posX, int posY)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.Black);
        board._squares[posX, posY] = new Square();
        board._squares[posX, posY].Piece = piece;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(0, possibleMoves.Count(), "There should be no valid moves for a black pawn at the bottom of the board");
    }

    [DataTestMethod]
    [DataRow(1, 1)]
    [DataRow(2, 1)]
    [DataRow(3, 1)]
    [DataRow(4, 1)]
    [DataRow(5, 1)]
    [DataRow(6, 1)]
    [DataRow(7, 1)]
    [DataRow(1, 2)]
    [DataRow(2, 2)]
    [DataRow(3, 2)]
    [DataRow(4, 2)]
    [DataRow(5, 2)]
    [DataRow(6, 2)]
    [DataRow(7, 2)]
    [DataRow(1, 3)]
    [DataRow(2, 3)]
    [DataRow(3, 3)]
    [DataRow(4, 3)]
    [DataRow(5, 3)]
    [DataRow(6, 3)]
    [DataRow(7, 3)]
    [DataRow(1, 4)]
    [DataRow(2, 4)]
    [DataRow(3, 4)]
    [DataRow(4, 4)]
    [DataRow(5, 4)]
    [DataRow(6, 4)]
    [DataRow(7, 4)]
    [DataRow(1, 5)]
    [DataRow(2, 5)]
    [DataRow(3, 5)]
    [DataRow(4, 5)]
    [DataRow(5, 5)]
    [DataRow(6, 5)]
    [DataRow(7, 5)]
    [DataRow(1, 6)]
    [DataRow(2, 6)]
    [DataRow(3, 6)]
    [DataRow(4, 6)]
    [DataRow(5, 6)]
    [DataRow(6, 6)]
    [DataRow(7, 6)]
    public void GetValidMoves_DiagLeft_WhitePawn_CanCaptureOpponent(int posX, int posY)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.White);
        var opponent = new Pawn(Piece.PieceColor.Black);
        var opponent2 = new Pawn(Piece.PieceColor.White);
        board._squares[posX, posY] = new Square();
        board._squares[posX, posY].Piece = piece;
        board._squares[posX - 1, posY + 1] = new Square();
        board._squares[posX - 1, posY + 1].Piece = opponent;
        board._squares[posX, posY + 1] = new Square();
        board._squares[posX, posY + 1].Piece = opponent2;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(1, possibleMoves.Count(), "There should be 1 valid diagonal capture move");

        var expectedMoves = new List<(int, int)>()
        {
            (posX - 1, posY + 1),
        };
        CollectionAssert.AreEquivalent(expectedMoves, possibleMoves.ToList());
    }

    [DataTestMethod]
    [DataRow(0, 1)]
    [DataRow(1, 1)]
    [DataRow(2, 1)]
    [DataRow(3, 1)]
    [DataRow(4, 1)]
    [DataRow(5, 1)]
    [DataRow(6, 1)]
    [DataRow(0, 2)]
    [DataRow(1, 2)]
    [DataRow(2, 2)]
    [DataRow(3, 2)]
    [DataRow(4, 2)]
    [DataRow(5, 2)]
    [DataRow(6, 2)]
    [DataRow(0, 3)]
    [DataRow(1, 3)]
    [DataRow(2, 3)]
    [DataRow(3, 3)]
    [DataRow(4, 3)]
    [DataRow(5, 3)]
    [DataRow(6, 3)]
    [DataRow(0, 4)]
    [DataRow(1, 4)]
    [DataRow(2, 4)]
    [DataRow(3, 4)]
    [DataRow(4, 4)]
    [DataRow(5, 4)]
    [DataRow(6, 4)]
    [DataRow(0, 5)]
    [DataRow(1, 5)]
    [DataRow(2, 5)]
    [DataRow(3, 5)]
    [DataRow(4, 5)]
    [DataRow(5, 5)]
    [DataRow(6, 5)]
    [DataRow(0, 6)]
    [DataRow(1, 6)]
    [DataRow(2, 6)]
    [DataRow(3, 6)]
    [DataRow(4, 6)]
    [DataRow(5, 6)]
    [DataRow(6, 6)]
    public void GetValidMoves_DiagRight_WhitePawn_CanCaptureOpponent(int posX, int posY)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.White);
        var opponent = new Pawn(Piece.PieceColor.Black);
        var opponent2 = new Pawn(Piece.PieceColor.White);
        board._squares[posX, posY] = new Square();
        board._squares[posX, posY].Piece = piece;
        board._squares[posX + 1, posY + 1] = new Square();
        board._squares[posX + 1, posY + 1].Piece = opponent;
        board._squares[posX, posY + 1] = new Square();
        board._squares[posX, posY + 1].Piece = opponent2;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(1, possibleMoves.Count(), "There should be 1 valid diagonal capture move");

        var expectedMoves = new List<(int, int)>()
        {
            (posX + 1, posY + 1),
        };
        CollectionAssert.AreEquivalent(expectedMoves, possibleMoves.ToList());
    }

    [DataTestMethod]
    [DataRow(1, 6)]
    [DataRow(2, 6)]
    [DataRow(3, 6)]
    [DataRow(4, 6)]
    [DataRow(5, 6)]
    [DataRow(6, 6)]
    [DataRow(7, 6)]
    [DataRow(1, 5)]
    [DataRow(2, 5)]
    [DataRow(3, 5)]
    [DataRow(4, 5)]
    [DataRow(5, 5)]
    [DataRow(6, 5)]
    [DataRow(7, 5)]
    [DataRow(1, 4)]
    [DataRow(2, 4)]
    [DataRow(3, 4)]
    [DataRow(4, 4)]
    [DataRow(5, 4)]
    [DataRow(6, 4)]
    [DataRow(7, 4)]
    [DataRow(1, 3)]
    [DataRow(2, 3)]
    [DataRow(3, 3)]
    [DataRow(4, 3)]
    [DataRow(5, 3)]
    [DataRow(6, 3)]
    [DataRow(7, 3)]
    [DataRow(1, 2)]
    [DataRow(2, 2)]
    [DataRow(3, 2)]
    [DataRow(4, 2)]
    [DataRow(5, 2)]
    [DataRow(6, 2)]
    [DataRow(7, 2)]
    [DataRow(1, 1)]
    [DataRow(2, 1)]
    [DataRow(3, 1)]
    [DataRow(4, 1)]
    [DataRow(5, 1)]
    [DataRow(6, 1)]
    [DataRow(7, 1)]
    public void GetValidMoves_DiagLeft_BlackPawn_CanCaptureOpponent(int posX, int posY)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.Black);
        var opponent = new Pawn(Piece.PieceColor.White);
        var opponent2 = new Pawn(Piece.PieceColor.Black);
        board._squares[posX, posY] = new Square();
        board._squares[posX, posY].Piece = piece;
        board._squares[posX - 1, posY - 1] = new Square();
        board._squares[posX - 1, posY - 1].Piece = opponent;
        board._squares[posX, posY - 1] = new Square();
        board._squares[posX, posY - 1].Piece = opponent2;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(1, possibleMoves.Count(), "There should be 1 valid diagonal capture move");

        var expectedMoves = new List<(int, int)>()
        {
            (posX - 1, posY - 1),
        };
        CollectionAssert.AreEquivalent(expectedMoves, possibleMoves.ToList());
    }

    [DataTestMethod]
    [DataRow(0, 6)]
    [DataRow(1, 6)]
    [DataRow(2, 6)]
    [DataRow(3, 6)]
    [DataRow(4, 6)]
    [DataRow(5, 6)]
    [DataRow(6, 6)]
    [DataRow(0, 5)]
    [DataRow(1, 5)]
    [DataRow(2, 5)]
    [DataRow(3, 5)]
    [DataRow(4, 5)]
    [DataRow(5, 5)]
    [DataRow(6, 5)]
    [DataRow(0, 4)]
    [DataRow(1, 4)]
    [DataRow(2, 4)]
    [DataRow(3, 4)]
    [DataRow(4, 4)]
    [DataRow(5, 4)]
    [DataRow(6, 4)]
    [DataRow(0, 3)]
    [DataRow(1, 3)]
    [DataRow(2, 3)]
    [DataRow(3, 3)]
    [DataRow(4, 3)]
    [DataRow(5, 3)]
    [DataRow(6, 3)]
    [DataRow(0, 2)]
    [DataRow(1, 2)]
    [DataRow(2, 2)]
    [DataRow(3, 2)]
    [DataRow(4, 2)]
    [DataRow(5, 2)]
    [DataRow(6, 2)]
    [DataRow(0, 1)]
    [DataRow(1, 1)]
    [DataRow(2, 1)]
    [DataRow(3, 1)]
    [DataRow(4, 1)]
    [DataRow(5, 1)]
    [DataRow(6, 1)]
    public void GetValidMoves_DiagRight_BlackPawn_CanCaptureOpponent(int posX, int posY)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.Black);
        var opponent = new Pawn(Piece.PieceColor.White);
        var opponent2 = new Pawn(Piece.PieceColor.Black);
        board._squares[posX, posY] = new Square();
        board._squares[posX, posY].Piece = piece;
        board._squares[posX + 1, posY - 1] = new Square();
        board._squares[posX + 1, posY - 1].Piece = opponent;
        board._squares[posX, posY - 1] = new Square();
        board._squares[posX, posY - 1].Piece = opponent2;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(1, possibleMoves.Count(), "There should be 1 valid diagonal capture move");

        var expectedMoves = new List<(int, int)>()
        {
            (posX + 1, posY - 1),
        };
        CollectionAssert.AreEquivalent(expectedMoves, possibleMoves.ToList());
    }

    [DataTestMethod]
    [DataRow(1, 1)]
    [DataRow(2, 1)]
    [DataRow(3, 1)]
    [DataRow(4, 1)]
    [DataRow(5, 1)]
    [DataRow(6, 1)]
    [DataRow(7, 1)]
    [DataRow(1, 2)]
    [DataRow(2, 2)]
    [DataRow(3, 2)]
    [DataRow(4, 2)]
    [DataRow(5, 2)]
    [DataRow(6, 2)]
    [DataRow(7, 2)]
    [DataRow(1, 3)]
    [DataRow(2, 3)]
    [DataRow(3, 3)]
    [DataRow(4, 3)]
    [DataRow(5, 3)]
    [DataRow(6, 3)]
    [DataRow(7, 3)]
    [DataRow(1, 4)]
    [DataRow(2, 4)]
    [DataRow(3, 4)]
    [DataRow(4, 4)]
    [DataRow(5, 4)]
    [DataRow(6, 4)]
    [DataRow(7, 4)]
    [DataRow(1, 5)]
    [DataRow(2, 5)]
    [DataRow(3, 5)]
    [DataRow(4, 5)]
    [DataRow(5, 5)]
    [DataRow(6, 5)]
    [DataRow(7, 5)]
    [DataRow(1, 6)]
    [DataRow(2, 6)]
    [DataRow(3, 6)]
    [DataRow(4, 6)]
    [DataRow(5, 6)]
    [DataRow(6, 6)]
    [DataRow(7, 6)]
    public void GetValidMoves_DiagLeft_WhitePawn_CannotCaptureOwnPiece(int posX, int posY)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.White);
        var ownPiece = new Pawn(Piece.PieceColor.White);
        var opponent2 = new Pawn(Piece.PieceColor.Black);
        board._squares[posX, posY] = new Square();
        board._squares[posX, posY].Piece = piece;
        board._squares[posX - 1, posY + 1] = new Square();
        board._squares[posX - 1, posY + 1].Piece = ownPiece;
        board._squares[posX, posY + 1] = new Square();
        board._squares[posX, posY + 1].Piece = opponent2;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(0, possibleMoves.Count(), "There should be no valid diagonal capture move for a white pawn capturing its own piece");
    }

    [DataTestMethod]
    [DataRow(0, 1)]
    [DataRow(1, 1)]
    [DataRow(2, 1)]
    [DataRow(3, 1)]
    [DataRow(4, 1)]
    [DataRow(5, 1)]
    [DataRow(6, 1)]
    [DataRow(0, 2)]
    [DataRow(1, 2)]
    [DataRow(2, 2)]
    [DataRow(3, 2)]
    [DataRow(4, 2)]
    [DataRow(5, 2)]
    [DataRow(6, 2)]
    [DataRow(0, 3)]
    [DataRow(1, 3)]
    [DataRow(2, 3)]
    [DataRow(3, 3)]
    [DataRow(4, 3)]
    [DataRow(5, 3)]
    [DataRow(6, 3)]
    [DataRow(0, 4)]
    [DataRow(1, 4)]
    [DataRow(2, 4)]
    [DataRow(3, 4)]
    [DataRow(4, 4)]
    [DataRow(5, 4)]
    [DataRow(6, 4)]
    [DataRow(0, 5)]
    [DataRow(1, 5)]
    [DataRow(2, 5)]
    [DataRow(3, 5)]
    [DataRow(4, 5)]
    [DataRow(5, 5)]
    [DataRow(6, 5)]
    [DataRow(0, 6)]
    [DataRow(1, 6)]
    [DataRow(2, 6)]
    [DataRow(3, 6)]
    [DataRow(4, 6)]
    [DataRow(5, 6)]
    [DataRow(6, 6)]
    public void GetValidMoves_DiagRight_WhitePawn_CannotCaptureOwnPiece(int posX, int posY)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.White);
        var ownPiece = new Pawn(Piece.PieceColor.White);
        var opponent2 = new Pawn(Piece.PieceColor.Black);
        board._squares[posX, posY] = new Square();
        board._squares[posX, posY].Piece = piece;
        board._squares[posX + 1, posY + 1] = new Square();
        board._squares[posX + 1, posY + 1].Piece = ownPiece;
        board._squares[posX, posY + 1] = new Square();
        board._squares[posX, posY + 1].Piece = opponent2;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(0, possibleMoves.Count(), "There should be no valid diagonal capture move for a white pawn capturing its own piece");
    }

    [DataTestMethod]
    [DataRow(1, 6)]
    [DataRow(2, 6)]
    [DataRow(3, 6)]
    [DataRow(4, 6)]
    [DataRow(5, 6)]
    [DataRow(6, 6)]
    [DataRow(7, 6)]
    [DataRow(1, 5)]
    [DataRow(2, 5)]
    [DataRow(3, 5)]
    [DataRow(4, 5)]
    [DataRow(5, 5)]
    [DataRow(6, 5)]
    [DataRow(7, 5)]
    [DataRow(1, 4)]
    [DataRow(2, 4)]
    [DataRow(3, 4)]
    [DataRow(4, 4)]
    [DataRow(5, 4)]
    [DataRow(6, 4)]
    [DataRow(7, 4)]
    [DataRow(1, 3)]
    [DataRow(2, 3)]
    [DataRow(3, 3)]
    [DataRow(4, 3)]
    [DataRow(5, 3)]
    [DataRow(6, 3)]
    [DataRow(7, 3)]
    [DataRow(1, 2)]
    [DataRow(2, 2)]
    [DataRow(3, 2)]
    [DataRow(4, 2)]
    [DataRow(5, 2)]
    [DataRow(6, 2)]
    [DataRow(7, 2)]
    [DataRow(1, 1)]
    [DataRow(2, 1)]
    [DataRow(3, 1)]
    [DataRow(4, 1)]
    [DataRow(5, 1)]
    [DataRow(6, 1)]
    [DataRow(7, 1)]
    public void GetValidMoves_DiagLeft_BlackPawn_CannotCaptureOwnPiece(int posX, int posY)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.Black);
        var ownPiece = new Pawn(Piece.PieceColor.Black);
        var opponent2 = new Pawn(Piece.PieceColor.White);
        board._squares[posX, posY] = new Square();
        board._squares[posX, posY].Piece = piece;
        board._squares[posX - 1, posY - 1] = new Square();
        board._squares[posX - 1, posY - 1].Piece = ownPiece;
        board._squares[posX, posY - 1] = new Square();
        board._squares[posX, posY - 1].Piece = opponent2;

        var possibleMoves = piece.GetValidMoves(board);
        Assert.AreEqual(0, possibleMoves.Count(), "There should be no valid diagonal capture move for a black pawn capturing its own piece");
    }

    [DataTestMethod]
    [DataRow(0, 6)]
    [DataRow(1, 6)]
    [DataRow(2, 6)]
    [DataRow(3, 6)]
    [DataRow(4, 6)]
    [DataRow(5, 6)]
    [DataRow(6, 6)]
    [DataRow(0, 5)]
    [DataRow(1, 5)]
    [DataRow(2, 5)]
    [DataRow(3, 5)]
    [DataRow(4, 5)]
    [DataRow(5, 5)]
    [DataRow(6, 5)]
    [DataRow(0, 4)]
    [DataRow(1, 4)]
    [DataRow(2, 4)]
    [DataRow(3, 4)]
    [DataRow(4, 4)]
    [DataRow(5, 4)]
    [DataRow(6, 4)]
    [DataRow(0, 3)]
    [DataRow(1, 3)]
    [DataRow(2, 3)]
    [DataRow(3, 3)]
    [DataRow(4, 3)]
    [DataRow(5, 3)]
    [DataRow(6, 3)]
    [DataRow(0, 2)]
    [DataRow(1, 2)]
    [DataRow(2, 2)]
    [DataRow(3, 2)]
    [DataRow(4, 2)]
    [DataRow(5, 2)]
    [DataRow(6, 2)]
    [DataRow(0, 1)]
    [DataRow(1, 1)]
    [DataRow(2, 1)]
    [DataRow(3, 1)]
    [DataRow(4, 1)]
    [DataRow(5, 1)]
    [DataRow(6, 1)]
    public void GetValidMoves_DiagRight_BlackPawn_CannotCaptureOwnPiece(int posX, int posY)
    {
        var board = new Board();
        var piece = new Pawn(Piece.PieceColor.Black);
        var ownPiece = new Pawn(Piece.PieceColor.Black);
        var opponent2 = new Pawn(Piece.PieceColor.White);
        board._squares[posX, posY] = new Square();
        board._squares[posX, posY].Piece = piece;
        board._squares[posX + 1, posY - 1] = new Square();
        board._squares[posX + 1, posY - 1].Piece = ownPiece;
        board._squares[posX, posY - 1] = new Square();
        board._squares[posX, posY - 1].Piece = opponent2;

        var possibleMoves = piece.GetValidMoves(board);

        Assert.AreEqual(0, possibleMoves.Count(), "There should be no valid diagonal capture move for a black pawn capturing its own piece");
    }
}