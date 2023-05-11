using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace FifteenPuzzle
{
    public class Game
    {
        int _numOfMoves = 0;

        //private int[,] _board = new int[4, 4]
        //{
        //    {01, 03, 10, 13},
        //    {04, 02, 00, 06},
        //    {11, 08, 07, 12},
        //    {09, 14, 05, 15}
        //};

        private int?[,] _board = new int?[4, 4]
        {
            { 01, 02, 03, 04 },
            { 05, 06, 07, 08 },
            { 09, 10, 11, 12 },
            { 13, 14, 00, 15 }
        };

        public int?[,] Board
        {
            get => _board;
            set => _board = value;
        }

        public int Moves
        {
            get => _numOfMoves;
            set => _numOfMoves = value;
        }

        public Game() 
        {
            /* The game needs to be able to generate random puzzles
            * to solve */
            this.Board = GeneratePuzzle();
            GetTilesMovePossible(this.Board);      
        }

        public void PrintBoard(Game game)
        {
            for (int i = 0; i <= game.Board.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= game.Board.GetLength(1) - 1; j++)
                {
                    Console.Write($"{game.Board[i, j]}\t");
                }

                Console.WriteLine();
            }
        }

        public void MoveTile(Game game, int tileNumber, string tileDirection)
        {   
            int tileNumNew = tileNumber;
            int positionTileNumNewXY;
            int postitionTileNumNewX;
            int postitionTileNumNewY;

            int? tileNumOld;

            bool isValidTileNumMove = false;
            bool isValidTileNumRange = false;

            game.Moves++;

            positionTileNumNewXY = GetPostitionTileNumXY(game.Board, tileNumNew);
            postitionTileNumNewX = GetFirstDigit(positionTileNumNewXY);
            postitionTileNumNewY = GetLastDigit(positionTileNumNewXY);

            isValidTileNumMove = CheckIfValidTileNumMove(game, tileNumNew, tileDirection);
            isValidTileNumRange = CheckIfValidTileNumRange(game, tileNumNew, tileDirection);

            //Console.WriteLine($"Is valid range {isValidTileNumRange}");

            if (isValidTileNumMove && isValidTileNumRange)
            {
                switch (tileDirection)
                {
                    case "up":
                        // update old tile
                        tileNumOld = game.Board[postitionTileNumNewX - 1, postitionTileNumNewY + 0];
                        game.Board[postitionTileNumNewX + 0, postitionTileNumNewY + 0] = tileNumOld;

                        // update new tile
                        game.Board[postitionTileNumNewX - 1, postitionTileNumNewY + 0] = tileNumNew;
                        break;
                    case "down":
                        // update old tile
                        tileNumOld = game.Board[postitionTileNumNewX + 1, postitionTileNumNewY + 0];
                        game.Board[postitionTileNumNewX + 0, postitionTileNumNewY + 0] = tileNumOld;

                        // update new tile
                        game.Board[postitionTileNumNewX + 1, postitionTileNumNewY + 0] = tileNumNew;
                        break;
                    case "left":
                        // update old tile
                        tileNumOld = game.Board[postitionTileNumNewX + 0, postitionTileNumNewY - 1];
                        game.Board[postitionTileNumNewX + 0, postitionTileNumNewY + 0] = tileNumOld;

                        // update new tile
                        game.Board[postitionTileNumNewX + 0, postitionTileNumNewY - 1] = tileNumNew;
                        break;
                    case "right":
                        // update old tile
                        tileNumOld = game.Board[postitionTileNumNewX + 0, postitionTileNumNewY + 1];
                        game.Board[postitionTileNumNewX + 0, postitionTileNumNewY + 0] = tileNumOld;

                        // update new tile
                        game.Board[postitionTileNumNewX + 0, postitionTileNumNewY + 1] = tileNumNew;
                        break;
                    default:
                        Console.WriteLine("An error has occured!");
                        break;
                }

            }
            else
            {
                Console.WriteLine($"\n{tileNumNew} is not a valid move!");
            }
        }

        public static int GetPostitionTileNumXY(int?[,] board, int tileNum)
        {
            int positionTileNumXY = tileNum;

            for (int i = 0; i <= board.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= board.GetLength(1) - 1; j++)
                {
                    if (tileNum == board[i, j])
                    {
                        positionTileNumXY = Convert.ToInt32($"{i}{j}");
                        break;
                    }
                }
            }

            return positionTileNumXY;
        }

        public static int GetFirstDigit(int num)
        {
            int firstDigit = 0;

            while(num >= 10)
            {
                firstDigit = num /= 10;
            }

            return firstDigit;
        }

        public static int GetLastDigit(int num)
        {
            int lastDigit = 0;

            lastDigit = num % 10;

            return lastDigit;
        }
    
        public static bool WinBoardCheck(int?[,] currentBoard)
        {
            int boardNumTiles = (currentBoard.GetLength(0) * currentBoard.GetLength(1));
            int boardNumTilesWin = 0;
            bool boardWin = false;

            int[,] correctBoard = new int[,]
            {
                { 01, 02, 03, 04 },
                { 05, 06, 07, 08 },
                { 09, 10, 11, 12 },
                { 13, 14, 15, 00 }
            };

            for (int i = 0; i <= correctBoard.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= correctBoard.GetLength(1) - 1; j++)
                {
                    if ((correctBoard[i, j] == currentBoard[i, j]))
                    {
                        boardNumTilesWin++;
                    }
                }
            }

            if(boardNumTiles == boardNumTilesWin)
            {
                boardWin = true;
            }

            return boardWin;
        }

        public static int?[] GetTilesMovePossible(int?[,] currentBoard) 
        {
            int tile00 = 0;
            int postitionTile00XY;
            int postitionTile00X;
            int postitionTile00Y;

            postitionTile00XY = GetPostitionTileNumXY(currentBoard, tile00);
            postitionTile00X = GetFirstDigit(postitionTile00XY);
            postitionTile00Y = GetLastDigit(postitionTile00XY);

            int? tileUp;
            int? tileDown;
            int? tileLeft;
            int? tileRight;
            int? tileCenter;

            // up
            if((postitionTile00X - 1) >= 0)
            {
                tileUp = currentBoard[postitionTile00X - 1, postitionTile00Y + 0];
            }
            else
            {
                tileUp = null;
            }

            // down
            if ((postitionTile00X + 1) < currentBoard.GetLength(0))
            {
                tileDown = currentBoard[postitionTile00X + 1, postitionTile00Y + 0];
            }
            else
            {
                tileDown = null;
            }

            // left
            if ((postitionTile00Y - 1) >= 0)
            {
                tileLeft = currentBoard[postitionTile00X + 0, postitionTile00Y - 1];
            }
            else
            {
                tileLeft = null;
            }

            // right
            if ((postitionTile00Y + 1) < currentBoard.GetLength(0))
            {
                tileRight = currentBoard[postitionTile00X + 0, postitionTile00Y + 1];
            }
            else
            {
                tileRight = null;
            }

            // center
            tileCenter = currentBoard[postitionTile00X + 0, postitionTile00Y + 0];

            // all possible tile moves possible
            int?[] tilesMovePossilbe = new int?[] { tileUp, tileLeft, tileCenter, tileRight, tileDown };

            return tilesMovePossilbe;
        }

        private bool CheckIfValidTileNumMove(Game game, int tileNum, string tileDirection) 
        {
            int positionTile00XY = GetPostitionTileNumXY(game.Board, 0);

            int positionTileNumXY = GetPostitionTileNumXY(game.Board, tileNum);
            int positionTileNumX = GetFirstDigit(positionTileNumXY);
            int positionTileNumY = GetLastDigit(positionTileNumXY);

            int positionTileNumXYExpected = -1;
            int positionTileNumXExpected;
            int positionTileNumYExpected;

            bool isValidTileNumMove = false;

            int?[] tilesMovePossible;

            tilesMovePossible = GetTilesMovePossible(game.Board);

            for (int i = 0; i <= tilesMovePossible.Length - 1; i++)
            {
                if (tileNum == tilesMovePossible[i])
                {
                    isValidTileNumMove = true;
                    break;
                }
            }

            // non-zero tile must switch with 0
            if(tileNum != 0) 
            { 
                switch(tileDirection)
                {
                    case "up":
                        positionTileNumXExpected = positionTileNumX - 1;
                        positionTileNumYExpected = positionTileNumY + 0;
                        positionTileNumXYExpected = Convert.ToInt32($"{positionTileNumXExpected}{positionTileNumYExpected}");
                        break;
                    case "down":
                        positionTileNumXExpected = positionTileNumX + 1;
                        positionTileNumYExpected = positionTileNumY + 0;
                        positionTileNumXYExpected = Convert.ToInt32($"{positionTileNumXExpected}{positionTileNumYExpected}");
                        break;
                    case "left":
                        positionTileNumXExpected = positionTileNumX + 0;
                        positionTileNumYExpected = positionTileNumY - 1;
                        positionTileNumXYExpected = Convert.ToInt32($"{positionTileNumXExpected}{positionTileNumYExpected}");
                        break;
                    case "right":
                        positionTileNumXExpected = positionTileNumX + 0;
                        positionTileNumYExpected = positionTileNumY + 1;
                        positionTileNumXYExpected = Convert.ToInt32($"{positionTileNumXExpected}{positionTileNumYExpected}");
                        break;
                }

                if (positionTileNumXYExpected != positionTile00XY)
                {
                    isValidTileNumMove = false;
                }
            }

            return isValidTileNumMove;
        }

        private bool CheckIfValidTileNumRange(Game game, int tileNum, string tileDirection)
        {
            int boardMinX = 0;
            int boardMaxX = game.Board.GetLength(0) - 1;
            int boardMinY = 0;
            int boardMaxY = game.Board.GetLength(1) - 1;

            int positionTileNumXY = GetPostitionTileNumXY(game.Board, tileNum);
            int postitionTileNumX = GetFirstDigit(positionTileNumXY);
            int postitionTileNumY = GetLastDigit(positionTileNumXY);

            bool isValidTileRange = false;

            switch (tileDirection)
            {
                case "up":
                    if (boardMinX <= postitionTileNumX - 1)
                    {
                        isValidTileRange = true;
                    }
                    break;
                case "down":
                    if (boardMaxX >= postitionTileNumX + 1)
                    {
                        isValidTileRange = true;
                    }
                    break;
                case "left":
                    if (boardMinY <= postitionTileNumY - 1)
                    {
                        isValidTileRange = true;
                    }
                    break;
                case "right":
                    if (boardMaxY >= postitionTileNumY + 1)
                    {
                        isValidTileRange = true;
                    }
                    break;
            }

            return isValidTileRange;
        }
    
        private int?[,] GeneratePuzzle()
        {
            int?[,] puzzle = new int?[4,4];
            int number;            

            for (int i = 0; i <= puzzle.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= puzzle.GetLength(1) - 1; j++)
                {
                    bool duplicate;

                    Random numberRandom = new Random();
                    number = numberRandom.Next(16);

                    duplicate = CheckForDuplicates(puzzle, number);

                    if (duplicate)
                    {
                        j--;
                        continue;  
                    }
                    else if (!duplicate)
                    {
                        puzzle[i, j] = number;
                    }
                }
            }

            return puzzle;
            

        }
    
        private bool CheckForDuplicates(int?[,] puzzle, int number)
        {
            int numOfduplicate = 0;
            bool duplicates = true;

            for (int i = 0; i <= puzzle.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < puzzle.GetLength(1); j++)
                {
                    if(puzzle[i, j] == number)
                    {
                        numOfduplicate++;
                    }
               
                }
            }

            if(numOfduplicate == 0)
            {
                duplicates = false;
            }

            return duplicates;
        }
    }   
}
