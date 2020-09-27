using System;

namespace HelloWorld
{
    internal class ChessBoard
    {
        private int numberOfChessPiecesOnBoard;

        public ChessBoard()
        {
            ChessPiecesMatrix = new ChessPieces[3, 3];
            for (var i = 0; i < ChessPiecesMatrix.GetLength(0); i++)
            for (var j = 0; j < ChessPiecesMatrix.GetLength(1); j++)
                ChessPiecesMatrix[i, j] = new ChessPieces((char) CHESS_PIECES_TYPE.UNKNOWN, new Vector(i, j));

            numberOfChessPiecesOnBoard = 0;
        }

        public ChessPieces[,] ChessPiecesMatrix { get; set; }

        public void Draw()
        {
            for (var row = 0; row < ChessPiecesMatrix.GetLength(0); row++)
            {
                for (var column = 0; column < ChessPiecesMatrix.GetLength(1); column++)
                    if (column == ChessPiecesMatrix.GetLength(1) - 1)
                        Console.Write(" " + ChessPiecesMatrix[row, column].Type);
                    else
                        Console.Write(" " + ChessPiecesMatrix[row, column].Type + " |");

                if (row != ChessPiecesMatrix.GetLength(0) - 1)
                {
                    Console.WriteLine();
                    Console.Write("---+---+---");
                    Console.WriteLine();
                }
            }
        }

        public void AddAChessPieces(ChessPieces chessPieces)
        {
            // check valid move
            var x = chessPieces.Position.X;
            var y = chessPieces.Position.Y;

            if (IsValidMove(x, y))
            {
                ChessPiecesMatrix[x, y] = chessPieces;
                numberOfChessPiecesOnBoard++;
            }
        }

        public bool IsValidMove(int x, int y)
        {
            if (x < 0 || x > ChessPiecesMatrix.GetLength(0) - 1)
                return false;

            if (y < 0 || y > ChessPiecesMatrix.GetLength(1) - 1)
                return false;

            if (ChessPiecesMatrix[x, y].Type != (char) CHESS_PIECES_TYPE.UNKNOWN)
                return false;

            return true;
        }

        //public int GetNumberOfChessPiecesOnBoard()
        //{
        //    for (int row = 0; row < ChessPiecesMatrix.GetLength(0); row++)
        //    {
        //        for (int column = 0; column < ChessPiecesMatrix.GetLength(1); column++)
        //        {
        //            if (ChessPiecesMatrix[row, column].Type != (char)CHESS_PIECES_TYPE.UNKNOWN)
        //                numberOfChessPiecesOnBoard++;
        //        }
        //    }

        //    return numberOfChessPiecesOnBoard;
        //}

        public bool IsTie()
        {
            if (!IsHasWinner() && numberOfChessPiecesOnBoard ==
                ChessPiecesMatrix.GetLength(0) * ChessPiecesMatrix.GetLength(1))
                return true;

            return false;
        }

        public bool IsHasWinner()
        {
            if (IsWinByHorizontal() || IsWinByVertical() || IsWinByDiagonal())
                return true;

            return false;
        }

        public bool IsWinByHorizontal()
        {
            var counter = 1;
            for (var row = 0; row < ChessPiecesMatrix.GetLength(0); row++)
            {
                if (ChessPiecesMatrix[row, 0].Type == (char) CHESS_PIECES_TYPE.UNKNOWN)
                    return false;

                for (var column = 1; column < ChessPiecesMatrix.GetLength(1); column++)
                    if (ChessPiecesMatrix[row, column].Type == ChessPiecesMatrix[row, 0].Type)
                        counter++;

                if (counter == 3)
                    return true;

                counter = 1; // reset counter for a new row
            }

            return false;
        }

        public bool IsWinByVertical()
        {
            var counter = 1;
            for (var column = 0; column < ChessPiecesMatrix.GetLength(1); column++)
            {
                if (ChessPiecesMatrix[0, column].Type == (char) CHESS_PIECES_TYPE.UNKNOWN)
                    return false;

                for (var row = 1; row < ChessPiecesMatrix.GetLength(0); row++)
                    if (ChessPiecesMatrix[row, column].Type == ChessPiecesMatrix[0, column].Type)
                        counter++;

                if (counter == 3)
                    return true;

                counter = 1; // reset counter for a new column
            }

            return false;
        }

        public bool IsWinByDiagonal()
        {
            if (IsWinByDiagonalLeft() || IsWinByDiagonalRight())
                return true;

            return false;
        }

        public bool IsWinByDiagonalLeft()
        {
            if (ChessPiecesMatrix[0, 0].Type == (char) CHESS_PIECES_TYPE.UNKNOWN)
                return false;

            var counter = 1;
            for (var row = 0; row < ChessPiecesMatrix.GetLength(0); row++)
            for (var column = 1; column < ChessPiecesMatrix.GetLength(1); column++)
                if (row == column && ChessPiecesMatrix[row, column].Type == ChessPiecesMatrix[0, 0].Type)
                    counter++;

            if (counter == 3)
                return true;

            return false;
        }

        public bool IsWinByDiagonalRight()
        {
            if (ChessPiecesMatrix[2, 0].Type == (char) CHESS_PIECES_TYPE.UNKNOWN)
                return false;

            var counter = 1;
            for (var row = 0; row < ChessPiecesMatrix.GetLength(0); row++)
            for (var column = 1; column < ChessPiecesMatrix.GetLength(1); column++)
                if (row + column == ChessPiecesMatrix.GetLength(0) - 1 &&
                    ChessPiecesMatrix[row, column].Type == ChessPiecesMatrix[2, 0].Type)
                    counter++;

            if (counter == 3)
                return true;

            return false;
        }
    }
}