using Mission4Assignment;

TicTacToeTools tttt = new TicTacToeTools();
string[] gameBoard = new string[8];
string currentPlayer = "X"; // Create a string for what it should mark the square with.
bool gameOver = false;

// welcome the user
Console.WriteLine("Welcome to THE GREATEST Tic Tac Toe board in THE WORLD!");
Console.WriteLine();

// Start game loop
do
{
    // create game board array to store players' choices
    
    // ask each player in turn for their choice
    int response = int.Parse(Console.ReadLine());
    
    // update the game board array


    // print the board by CALLING the method in the supporting class
        tttt.printBoard(board);

    // check for a winner by CALLING the method in the supporting class
        result = tttt.checkWinner();

    // notify the players when a win has occurred and which player won the game
        if (result == True)
        {
            gameOver = true;
        }
} while (!gameOver);
