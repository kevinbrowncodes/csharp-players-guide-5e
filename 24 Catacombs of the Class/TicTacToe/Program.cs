namespace TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            char position;

            Console.WriteLine("\nTic-Tac-Toe\n");  

            Game game = new Game();

            /* Two human players take turns entering their choice using 
            * the same keyboard */
            /* The players designate which square they want to play in. */
            while (!game.EndGame)
            {
                game.DeterminePlayerTurn();
                ConsoleColor consoleColor = game.PlayerTurn == 'X' ? ConsoleColor.Yellow : ConsoleColor.Magenta;
                Console.ForegroundColor = consoleColor;
                Console.WriteLine($"\nIt's is {game.PlayerTurn}'s turn.");
                Console.ForegroundColor = ConsoleColor.Gray;
                game.PrintBoard();
                Console.WriteLine("\nWhat square do you want to play in?");
                position = Convert.ToChar(Console.ReadLine());
                bool positionValid = game.CheckPositionValid(position);
                if (positionValid)
                {
                    game.UpdateBoard(position);
                    game.CheckBoard();
                    game.NumOfTurns++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nInvalid position!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }   
        }
    }
}