using Mission4Assignment;

TicTacToeTools tttt = new TicTacToeTools();
string[] gameBoard = new string[9];
string currentPlayer = "X"; // Create a string for what it should mark the square with.
bool gameOver = false;

// welcome the user
Console.WriteLine("Welcome to THE GREATEST Tic Tac Toe board in THE WORLD!");
Console.WriteLine();

// Start game loop
do
{
    // ask each player in turn for their choice
    Console.WriteLine(currentPlayer + ", enter a position (1-9):");
    string input = Console.ReadLine();
    int response = 0;
    
    //Validate input
    while (true)
    {
        // Check if it's a valid integer
        if (!int.TryParse(input, out response))
        {
            Console.WriteLine("Please enter a number.");
            input = Console.ReadLine();
        }
        // Check if it's in range 1-9
        else if (response < 1 || response > 9)
        {
            Console.WriteLine("Please enter a number between 1 and 9.");
            input = Console.ReadLine();
        }
        // Check if the spot is already taken
        else if (gameBoard[response - 1] != null)
        {
            Console.WriteLine("That spot is already taken. Choose another.");
            input = Console.ReadLine();
        }
        else
        {
            break; // Valid input, exit loop
        }
        
    }
    
    // update the game board array
    gameBoard[response - 1] = currentPlayer; //Use response to locate that spot, then fill in currentPlayer's symbol

    // print the board by CALLING the method in the supporting class
    tttt.printBoard(gameBoard);

    // check for a winner by CALLING the method in the supporting class
    string result = tttt.checkWinner(gameBoard);

    // notify the players when a win has occurred and which player won the game
    if (result == "X" || result == "O")
    {
        Console.WriteLine(result + " wins!");
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