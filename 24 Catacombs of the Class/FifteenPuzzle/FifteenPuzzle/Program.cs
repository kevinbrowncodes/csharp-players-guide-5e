namespace FifteenPuzzle
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool winBoard = false;
            int tileNum = 0;
            string tileDirection;
            int?[] tilesMovePossible;

            Game game = new Game();

            while (!winBoard)
            {
                Console.WriteLine("\nnumber of moves");
                Console.WriteLine(game.Moves);

                /* The current state of the game needs to be displayed to the 
                * user */
                Console.WriteLine("\npuzzle");
                game.PrintBoard(game);

                int?[,] test = game.Board;

                tilesMovePossible = Game.GetTilesMovePossible(game.Board);

                Console.WriteLine("\navailable tile moves");
                Console.WriteLine($"\t{tilesMovePossible[0]}");
                Console.WriteLine($"{tilesMovePossible[1]}\t{tilesMovePossible[2]}\t{tilesMovePossible[3]}");
                Console.WriteLine($"\t{tilesMovePossible[4]}");

                /* The player needs to be able to manipulate the board to 
                * rearrange it. */
                bool correctTileNumInput = false;
                string tileNumInput;
                while (!correctTileNumInput) {
                    Console.WriteLine("\nWhich tile do you want to move?");
                    tileNumInput = Console.ReadLine();

                    if(!int.TryParse(tileNumInput, out tileNum))
                    {
                        Console.WriteLine("\nNot a number!");
                    }
                    else
                    {
                        tileNum = Convert.ToInt32(tileNumInput);
                        correctTileNumInput = true;
                    }
                }

                bool correctTileDirectionInput = false;
                string tileDirectionInput = "";
                while (!correctTileDirectionInput) 
                {
                    Console.WriteLine("\nWhat direction do you want to move the selected tile?");
                    Console.WriteLine("up");
                    Console.WriteLine("down");
                    Console.WriteLine("left");
                    Console.WriteLine("right");
                    Console.WriteLine();
                    tileDirectionInput = Console.ReadLine();

                    switch (tileDirectionInput) 
                    {
                        case "up":
                            correctTileDirectionInput = true; break;
                        case "down":
                            correctTileDirectionInput = true; break;
                        case "left":
                            correctTileDirectionInput = true; break;
                        case "right":
                            correctTileDirectionInput = true; break;
                    }
                }

                tileDirection = tileDirectionInput;

                game.MoveTile(game, tileNum, tileDirection);

                /* The game needs to detect when it has been solved and tell
                * the player they won */
                winBoard = Game.WinBoardCheck(game.Board);
                if (winBoard)
                {
                    Console.WriteLine("\npuzzle");
                    game.PrintBoard(game);
                    Console.WriteLine($"\nThe game is won!");

                }
                
                Console.WriteLine();
            }
            
        }
    }
}