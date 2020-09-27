using System;

namespace HelloWorld
{
    internal class Game
    {
        private readonly ChessBoard board;
        private int turn;

        public Game()
        {
            board = new ChessBoard();
            turn = 0;
        }

        public void Start()
        {
            var isValidMove = true;
            Console.WriteLine("Welcome to Tic tac toe!");

            while (!board.IsHasWinner() && !board.IsTie())
            {
                if (IsTurnOfPlayerX())
                {
                    Console.WriteLine("\nIt's X player turn");
                    Console.Write("Enter a move: x = ");
                    var x = Convert.ToInt32(Console.ReadLine());
                    Console.Write(" y = ");
                    var y = Convert.ToInt32(Console.ReadLine());

                    var chessPieces = new ChessPieces((char) CHESS_PIECES_TYPE.X, new Vector(x, y));
                    if (board.IsValidMove(chessPieces.Position.X, chessPieces.Position.Y))
                    {
                        isValidMove = true;
                        board.AddAChessPieces(chessPieces);
                    }
                    else
                    {
                        isValidMove = false;
                        Console.WriteLine("Invalid move!");
                    }
                }
                else
                {
                    Console.WriteLine("\nIt's O player turn");
                    Console.Write("Enter a move: x = ");
                    var x = Convert.ToInt32(Console.ReadLine());
                    Console.Write(" y = ");
                    var y = Convert.ToInt32(Console.ReadLine());

                    var chessPieces = new ChessPieces((char) CHESS_PIECES_TYPE.O, new Vector(x, y));
                    if (board.IsValidMove(chessPieces.Position.X, chessPieces.Position.Y))
                    {
                        isValidMove = true;
                        board.AddAChessPieces(chessPieces);
                    }
                    else
                    {
                        isValidMove = false;
                        Console.WriteLine("Invalid move!");
                    }
                }

                Console.WriteLine();
                board.Draw();

                if (isValidMove)
                    turn++;
            }

            Console.WriteLine("\nGame over!");
        }

        private bool IsTurnOfPlayerX()
        {
            if (turn % 2 == 0)
                return true;

            return false;
        }
    }
}