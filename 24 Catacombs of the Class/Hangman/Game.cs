using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class Game
    {
        private string? _word;
        private string _wordGuess;
        private int? _remaining;
        private char?[] _lettersIncorrect;
        private string _incorrect;
        private char _letterGuess;
        private bool _gameWon;
        private bool _gameEnd;
        private int _round;
        
        public string? Word
        {
            get => _word;
            set => _word = value;
        }

        public int? Remaining
        {
            get => _remaining;
            set => _remaining = value;  
        }

        public char?[] LettersIncorrect
        {
            get => _lettersIncorrect;
            set => _lettersIncorrect = value;
        }

        public char LetterGuess
        {
            get => _letterGuess;
            set => _letterGuess = value;
        }

        public bool GameWon
        {
            get => _gameWon;
            private set => _gameWon = value;
        }

        public string WordGuess
        {
            get => _wordGuess;
            set => _wordGuess = value; 
        }
        
        public bool GameEnd
        {
            get => _gameEnd;
            set => _gameEnd = value;
        }

        public int Round
        {
            get => _round;
            set => _round = value;
        }
        
        public string Incorrect
        {
            get => _incorrect;
            set => _incorrect = value;
        }

        public Game() 
        {
            this.Word = ReturnRandomWord();
            this.WordGuess = CreateWordGuess();
            this.Remaining = 5;
            this.LettersIncorrect = new char?[5];
            this.Round = 0;
            this.GameEnd = false;
            this.Incorrect = "";
        }


        public void UpdateWordGuess(Game game) 
        {
            char[] lettersWord = game.Word.ToArray();
            char[] lettersWordGuess = game.WordGuess.ToArray();
            char letterGuess = game.LetterGuess;
            

            // is game.LetterGuess in game.Word
            // if so add letter to game.WordGuess
            for (int i = 0; i <= lettersWord.Length - 1; i++)
            {
                if (lettersWord[i] == letterGuess)
                {
                    lettersWordGuess[i] = letterGuess;
                }
            }

            game.WordGuess = new string(lettersWordGuess);
        }

        /* The game needs to detect a win for the player (all letters
         * have been guessed). */
        /* The game needs to detect a loss for the player (out of 
         * incorrect guesses). */
        public void  CheckIfGameWon(Game game)
        {
            if (game.Word == game.WordGuess)
            {
                Console.WriteLine($"Word: {game.WordGuess} | Remaining: {game.Remaining} | Incorrect: {game.Incorrect} | Guess: {game.LetterGuess}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nYou won!");
                Console.ForegroundColor = ConsoleColor.Gray;
                game.GameWon = true;
                game.GameEnd = true;
            }
            else
            {               
                game.Round++;
            }
        }

        /* The game picks a word at random from a list of words */
        private string ReturnRandomWord()
        {
            string[] wordBank = {"hero", "princess", "monster", "sword"};
            int WordBankLength = wordBank.Length;
            string wordRandom;

            Random number = new Random();
            int randomNumber = number.Next(0, WordBankLength);

            wordRandom = wordBank[randomNumber];

            return wordRandom;
        }
    
        private string CreateWordGuess()
        {
            string wordGuess;
            char[] lettersWord = this.Word.ToArray();
            char[] lettersWordGuess = new char[lettersWord.Length];
            // create wordGuess
            for (int i = 0; i <= lettersWord.Length - 1; i++)
            {
                lettersWordGuess[i] = '-';
            }

            wordGuess = new string(lettersWordGuess);

            return wordGuess;
        }
    
        public void UpdateRemaining(Game game)
        {
            char[] lettersWord = game.Word.ToArray();
            bool correctLetterFound = false;

            for (int i = 0; i <= lettersWord.Length - 1; i++)
            {
                if (lettersWord[i] == game.LetterGuess)
                {
                    correctLetterFound = true;
                }
            }

            if(!correctLetterFound) 
            {
                UpdateLettersIncorrect(this);
                game.Remaining--;
            }

            if(game.Remaining == 0)
            {
                game.GameEnd = true;
            }
        }
    
        public void UpdateLettersIncorrect(Game game)
        {
            char[] lettersWord = game.Word.ToArray();
            bool letterCorrect = true;

            for (int i = 0; i <= lettersWord.Length - 1; i++)
            {
                if (lettersWord[i] != game.LetterGuess)
                {
                    letterCorrect = false;
                }
            }

            if (!letterCorrect)
            {
                for (int j = 0; j <= this.LettersIncorrect.Length - 1; j++)
                {
                    if (!this.LettersIncorrect[j].HasValue)
                    {
                        this.LettersIncorrect[j] = game.LetterGuess;
                        break;
                    }
                }
            }

            game.Incorrect = string.Concat(this.LettersIncorrect);
        }

        /* The player can pick a letter. If they pick a letter they
         * already chose, pick again */
        public bool CheckForValidLetter(Game game)
        {
            bool validLetter = true;

            char[] lettersWordGuess = game.WordGuess.ToArray();
            char?[] lettersIncorrect = game.LettersIncorrect;
            char?[] lettersUsed = new char?[lettersWordGuess.Length + lettersIncorrect.Length];
            // copy using a loop
            for (int i = 0; i <= lettersWordGuess.Length - 1; i++)
            {
                lettersUsed[i] = lettersWordGuess[i];
            }
            for (int i = 0; i < lettersIncorrect.Length - 1; i++)
            {
                lettersUsed[lettersWordGuess.Length + i] = lettersIncorrect[i];
            }
       
            for (int i = 0; i <= lettersUsed.Length - 1; i++)
            {
                if (game.LetterGuess == lettersUsed[i])
                {
                    Console.WriteLine($"You already used letter {LetterGuess}");
                    validLetter = false;
                }
            }            
            return validLetter;
        }
    }
}
