using Mission4Assignment;

TicTacToeTools tttt = new TicTacToeTools();
string gameBoard = "123456789"; // Numbers show available positions
string currentPlayer = "X"; // Create a string for what it should mark the square with.
bool gameOver = false;
int moveCount = 0;

// welcome the user
Console.WriteLine("Welcome to THE GREATEST Tic Tac Toe board in THE WORLD!");
tttt.PrintBoard(gameBoard);

// Start game loop
do
{
    // ask each player in turn for their choice
    Console.Write(currentPlayer + ", enter a position (1-9): ");
    string input = Console.ReadLine();
    int response = 0;
    
    // Validate input
    while (true)
    {
        // Check if it's a valid integer
        if (!int.TryParse(input, out response))
        {
            Console.Write("Please enter a number: ");
            input = Console.ReadLine();
        }
        // Check if it's in range 1-9
        else if (response < 1 || response > 9)
        {
            Console.Write("Please enter a number between 1 and 9: ");
            input = Console.ReadLine();
        }
        // Check if the spot is already taken
        else if (gameBoard[response - 1] == 'X' || gameBoard[response - 1] == 'O')
        {
            Console.Write("That spot is already taken. Enter a different number: ");
            input = Console.ReadLine();
        }
        else
        {
            break; // Valid input, exit loop
        }
    }
    
    // update the game board array
    gameBoard = gameBoard.Substring(0, response - 1) + currentPlayer + gameBoard.Substring(response); // Update the board
    moveCount++;

    // print the board by CALLING the method in the supporting class
    tttt.PrintBoard(gameBoard);

    // check for a winner by CALLING the method in the supporting class
    int result = tttt.CheckWinner(gameBoard);

    // notify the players when a win has occurred and which player won the game
    if (result != 0)
    {
        Console.WriteLine((result == 1 ? "X" : "O") + " wins!");
        gameOver = true;
    }

    // notify the players when a tie has occurred 
    if (moveCount == 9 && result == 0)
    {
        Console.WriteLine("It's a tie!");
        gameOver = true;
    }
    
    // Switch to the other player
    if (currentPlayer == "X")
    {
        currentPlayer = "O";
    }
    else
    {
        currentPlayer = "X";
    }
} while (!gameOver);