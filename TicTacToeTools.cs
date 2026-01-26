using System;
using System.Collections.Generic;
using System.Text;

namespace Mission4Assignment
{
    internal class TicTacToeTools
    {
        // receive the board array from the driver class
        // contain a method that prints the board based on the information passed to it
        public void PrintBoard(string board)
        {
            for (int i = 0; i < board.Length; i += 3)
            {
                Console.WriteLine($"{board[i]} | {board[i + 1]} | {board[i + 2]}");
                if (i < 6)
                {
                    Console.WriteLine("- - - - -");
                }
            }
        }
        // contain a method that receives the game board array as input and returns if there is a winner and who it was
        public int CheckWinner(string board)
        {
            return 0;
        }
    }
}