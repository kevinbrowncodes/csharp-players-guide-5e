namespace Hangman
{
    public class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            /* The game's state is displayed to the player, as shown above */
            /* The game should update its state based on the letter the 
            * player picked */
            while (!game.GameEnd)
            {
                Console.WriteLine($"Word: {game.WordGuess} | Remaining: {game.Remaining} | Incorrect: {game.Incorrect} | Guess: {game.LetterGuess}");

                Console.Write("Guess letter: ");
                game.LetterGuess = Convert.ToChar(Console.ReadLine());
                if (game.CheckForValidLetter(game))
                {
                    game.UpdateWordGuess(game);
                    game.UpdateRemaining(game);
                    game.CheckIfGameWon(game);
                }     
            }
        }
    }
}