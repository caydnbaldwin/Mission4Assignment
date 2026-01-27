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
            Console.WriteLine();
            for (int i = 0; i < board.Length; i += 3)
            {
                Console.WriteLine($"{board[i]} | {board[i + 1]} | {board[i + 2]}");
                if (i < 6)
                {
                    Console.WriteLine("- - - - -");
                }
            }
            Console.WriteLine();
        }
        // contain a method that receives the game board array as input and returns if there is a winner and who it was
        public int CheckWinner(string board)
        {
            int winner = 0;
            
            // Check Rows
            if (board[0] == board[1] && board[1] == board[2] && board[0] != ' ') winner = board[0] == 'X' ? 1 : 2;
            if (board[3] == board[4] && board[4] == board[5] && board[3] != ' ') winner = board[3] == 'X' ? 1 : 2;
            if (board[6] == board[7] && board[7] == board[8] && board[6] != ' ') winner = board[6] == 'X' ? 1 : 2;
    
            // Check Columns
            if (board[0] == board[3] && board[3] == board[6] && board[0] != ' ') winner = board[0] == 'X' ? 1 : 2;
            if (board[1] == board[4] && board[4] == board[7] && board[1] != ' ') winner = board[1] == 'X' ? 1 : 2;
            if (board[2] == board[5] && board[5] == board[8] && board[2] != ' ') winner = board[2] == 'X' ? 1 : 2;
    
            // Check Diagonals
            if (board[0] == board[4] && board[4] == board[8] && board[0] != ' ') winner = board[0] == 'X' ? 1 : 2;
            if (board[2] == board[4] && board[4] == board[6] && board[2] != ' ') winner = board[2] == 'X' ? 1 : 2;
    
            return winner;
        }
    }
}