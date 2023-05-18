using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Game
    {
        private bool _endGame = false;
        private int _numOfTurns = 1;
        private string[,] _board = new string[3,3];
        private char _playerTurn;
        private char[] _positionsAvailableX;
        private char[] _positionsAvailableO;
        private bool _draw;

        public string[,] Board
        {
            get => _board; 
            set => _board = value;
        }
        public bool EndGame
        {
            get => _endGame;
            set => _endGame = value;
        }
        public int NumOfTurns
        {
            get => _numOfTurns;
            set => _numOfTurns = value;
        }
        public char PlayerTurn
        {
            get => _playerTurn;
            set => _playerTurn = value;
        }
        public char[] PositionsAvailableX
        {
            get => _positionsAvailableX;
            set => _positionsAvailableX = value;
        }
        public char[] PositionsAvailableO
        {
            get => _positionsAvailableO;
            set => _positionsAvailableO = value;
        }
        public bool Draw
        {
            get => _draw;
            private set => _draw = value;   
        }

        public Game() 
        { 
            this.Board = BuildBoard();
            this.PositionsAvailableX = new char[] { 'q', 'w', 'e', 'a', 's', 'd', 'z', 'x', 'c' };
            this.PositionsAvailableO = new char[] { 'i', 'o', 'p', 'j', 'k', 'l', 'n', 'm', ',' };
        }

        private string[,] BuildBoard()
        {
            string[,] board = new string[3,3];

            board[0, 0] = "   ";
            board[0, 1] = "   ";
            board[0, 2] = "   ";
            board[1, 0] = "   ";
            board[1, 1] = "   ";
            board[1, 2] = "   ";
            board[2, 0] = "   ";
            board[2, 1] = "   ";
            board[2, 2] = "   ";

            return board;
        }

        /* The state of the board must be displayed to the player
         * after each play */
        public void PrintBoard()
        {
            Console.WriteLine($"{Board[0, 0]}|{Board[0, 1]}|{Board[0, 2]}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($"{Board[1, 0]}|{Board[1, 1]}|{Board[1, 2]}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($"{Board[2, 0]}|{Board[2, 1]}|{Board[2, 2]}");

            Console.WriteLine();

            if(PlayerTurn == 'X')
            {
                Console.WriteLine($" q | w | e ");
                Console.WriteLine("---+---+---");
                Console.WriteLine($" a | s | d ");
                Console.WriteLine("---+---+---");
                Console.WriteLine($" z | x | c ");
            }

            if (PlayerTurn == 'O')
            {
                Console.WriteLine($" i | o | p ");
                Console.WriteLine("---+---+---");
                Console.WriteLine($" j | k | l ");
                Console.WriteLine("---+---+---");
                Console.WriteLine($" n | m | . ");
            }
        }
    
        public void UpdateBoard(char position)
        {
            switch (position)
            {
                case 'q':
                    this.Board[0, 0] = " X ";
                    break;
                case 'w':
                    this.Board[0, 1] = " X ";
                    break;
                case 'e':
                    this.Board[0, 2] = " X ";
                    break;
                case 'a':
                    this.Board[1, 0] = " X ";
                    break;
                case 's':
                    this.Board[1, 1] = " X ";
                    break;
                case 'd':
                    this.Board[1, 2] = " X ";
                    break;
                case 'z':
                    this.Board[2, 0] = " X ";
                    break;
                case 'x':
                    this.Board[2, 1] = " X ";
                    break;
                case 'c':
                    this.Board[2, 2] = " X ";
                    break;
                default:
                    break;
            }

            switch (position)
            {
                case 'i':
                    this.Board[0, 0] = " O ";
                    break;
                case 'o':
                    this.Board[0, 1] = " O ";
                    break;
                case 'p':
                    this.Board[0, 2] = " O ";
                    break;
                case 'j':
                    this.Board[1, 0] = " O ";
                    break;
                case 'k':
                    this.Board[1, 1] = " O ";
                    break;
                case 'l':
                    this.Board[1, 2] = " O ";
                    break;
                case 'n':
                    this.Board[2, 0] = " O ";
                    break;
                case 'm':
                    this.Board[2, 1] = " O ";
                    break;
                case ',':
                    this.Board[2, 2] = " O ";
                    break;
                default:
                    break;
            }
        }

        /* The game must detect when a player wins or when the board
         * if full with no winner (draw) */
        /* When the game is over, the outcome is displayed
        * to the players */
        public void CheckBoard()
        {
            bool winBoard = false;
            string tileElement;

            if (PlayerTurn == 'X')
            {
                tileElement = " X ";
            }
            else
            {
                tileElement = " O ";
            }

            // 8 winning patterns
            /// vertical
            string[,] boardWin01 = BuildBoard();
            boardWin01[0, 0] = tileElement;
            boardWin01[1, 0] = tileElement;
            boardWin01[2, 0] = tileElement;

            string[,] boardWin02 = BuildBoard();
            boardWin02[0, 1] = tileElement;
            boardWin02[1, 1] = tileElement;
            boardWin02[2, 1] = tileElement;

            string[,] boardWin03 = BuildBoard();
            boardWin03[0, 2] = tileElement;
            boardWin03[1, 2] = tileElement;
            boardWin03[2, 2] = tileElement;

            /// horizontal
            string[,] boardWin04 = BuildBoard();
            boardWin04[0, 0] = tileElement;
            boardWin04[0, 1] = tileElement;
            boardWin04[0, 2] = tileElement;

            string[,] boardWin05 = BuildBoard();
            boardWin05[1, 0] = tileElement;
            boardWin05[2, 1] = tileElement;
            boardWin05[1, 2] = tileElement;

            string[,] boardWin06 = BuildBoard();
            boardWin06[2, 0] = tileElement;
            boardWin06[2, 1] = tileElement;
            boardWin06[2, 2] = tileElement;

            /// cross
            string[,] boardWin07 = BuildBoard();
            boardWin07[0, 0] = tileElement;
            boardWin07[1, 1] = tileElement;
            boardWin07[2, 2] = tileElement;

            string[,] boardWin08 = BuildBoard();
            boardWin08[0, 2] = tileElement;
            boardWin08[1, 1] = tileElement;
            boardWin08[2, 0] = tileElement;
            
            string[][,] allBoardWins = new string[][,]
            {
                boardWin01,
                boardWin02,
                boardWin03,
                boardWin04,
                boardWin05,
                boardWin06,
                boardWin07,
                boardWin08,   
            };

            // find a matching board            
            foreach (var boardWin in allBoardWins)
            {
                int boardWinElementCounter = 0;
                for (int i = 0; i <= boardWin.GetLength(0) - 1; i++)
                {
                    for (int j = 0; j <= boardWin.GetLength(1) - 1; j++)
                    {
                        // for Player Turn X
                        if (PlayerTurn == 'X')
                        {
                            bool isX = false;
                            if (this.Board[i, j] == " X ")
                            {
                                isX = true;
                            }

                            if ((isX) && (boardWin[i, j] == this.Board[i, j]))
                            {
                                boardWinElementCounter++;
                            }
                        }
                        
                        // for Player Turn O
                        if(PlayerTurn == 'O')
                        {
                            bool isO = false;
                            if (this.Board[i, j] == " O ")
                            {
                                isO = true;
                            }

                            if ((isO) && (boardWin[i, j] == this.Board[i, j]))
                            {
                                boardWinElementCounter++;
                            }
                        } 
                    }

                    // there is a winning board
                    if (boardWinElementCounter == 3)
                    {
                        winBoard = true;
                        this.PrintBoard();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\nPlayer {PlayerTurn} wins!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    }

                    // there is a draw
                    if (PlayerTurn == 'X')
                    {
                        if (PositionsAvailableX.Length == 0)
                        {
                            Draw = true;
                            this.PrintBoard();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"\nDraw!");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                        }
                    }
                    if (PlayerTurn == 'O')
                    {
                        if (PositionsAvailableO.Length == 0)
                        {
                            Draw = true;
                            this.PrintBoard();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"\nDraw!");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                        }
                    }

                }
                
                // determine win
                if (winBoard || Draw)
                {
                    EndGame = true;
                    break;
                }
            }
        }
    
        public void DeterminePlayerTurn()
        {
            char playerTurn;

            if(this.NumOfTurns%2 == 0)
            {
                playerTurn = 'O';
            }
            else
            {
                playerTurn = 'X';
            }

            this.PlayerTurn = playerTurn;
        }

        /* The game would prevent players from choosing squares that 
         * are already ocupied. If such a move is attempted, the 
         * player should be told of the problem and given 
         * another chance */
        public bool CheckPositionValid(char position)
        {
            bool positionValid = false;
            bool positionValidMoveKey = false;
            bool positionValidMoveAvailable = false;
            char[] positionForX = new char[] { 'q', 'w', 'e', 'a', 's', 'd', 'z', 'x', 'c' };
            char[] positionForO = new char[] { 'i', 'o', 'p', 'j', 'k', 'l', 'n', 'm', ',' };

            if(PlayerTurn == 'X')
            {
                
                // check if position is a valid keyboard move
                for (int i = 0; i <= positionForX.Length - 1; i++)
                {
                    if (positionForX[i] == position) 
                    {
                        positionValidMoveKey = true;
                        break;
                    }
                }

                // check if position is valid available move
                for (int i = 0; i <= PositionsAvailableX.Length - 1; i++)
                {
                    if (PositionsAvailableX[i] == position)
                    {
                        positionValidMoveAvailable = true;
                        break;
                    }
                }

                if(positionValidMoveKey && positionValidMoveAvailable) 
                {
                    // remove that position from available X
                    for (int i = 0; i <= PositionsAvailableX.Length - 1; i++)
                    {
                        if (PositionsAvailableX[i] == position)
                        {
                            PositionsAvailableX[i] = '0';
                        }
                    }
                    // remove that position from available O
                    for (int i = 0; i <= PositionsAvailableO.Length - 1; i++)
                    {
                        char positionO = GetInputPositionTranslated(this.PlayerTurn, position);
                        if (PositionsAvailableO[i] == positionO)
                        {
                            PositionsAvailableO[i] = '0';
                        }
                    }

                    // clean up the array for X
                    char[] tempPositionsAvailableX = new char[PositionsAvailableX.Length - 1];
                    int tempPositionsAvailableXi = 0;
                    for (int i = 0; i <= PositionsAvailableX.Length - 1; i++)
                    {              
                        if (PositionsAvailableX[i] != '0')
                        {
                            tempPositionsAvailableX[tempPositionsAvailableXi] = PositionsAvailableX[i];
                            tempPositionsAvailableXi++;
                        }
                    }
                    PositionsAvailableX = tempPositionsAvailableX;

                    // clean up the array for O
                    char[] tempPositionsAvailableO = new char[PositionsAvailableO.Length - 1];
                    int tempPositionsAvailableOi = 0;
                    for (int i = 0; i <= PositionsAvailableO.Length - 1; i++)
                    {
                        if (PositionsAvailableO[i] != '0')
                        {
                            tempPositionsAvailableO[tempPositionsAvailableOi] = PositionsAvailableO[i];
                            tempPositionsAvailableOi++;
                        }
                    }
                    PositionsAvailableO = tempPositionsAvailableO;

                }
            }

            if (PlayerTurn == 'O')
            {

                // check if position is a valid keyboard move
                for (int i = 0; i <= positionForO.Length - 1; i++)
                {
                    if (positionForO[i] == position)
                    {
                        positionValidMoveKey = true;
                        break;
                    }
                }

                // check if position is valid available move
                for (int i = 0; i <= PositionsAvailableO.Length - 1; i++)
                {
                    if (PositionsAvailableO[i] == position)
                    {
                        positionValidMoveAvailable = true;
                        break;
                    }
                }

                // check if position is valid available move
                if (positionValidMoveKey && positionValidMoveAvailable)
                {
                    // remove that position from available O
                    for (int i = 0; i <= PositionsAvailableO.Length - 1; i++)
                    {
                        if (PositionsAvailableO[i] == position)
                        {
                            PositionsAvailableO[i] = '0';
                        }
                    }
                    // remove that position from available X
                    for (int i = 0; i <= PositionsAvailableX.Length - 1; i++)
                    {
                        char positionX = GetInputPositionTranslated(this.PlayerTurn, position);
                        if (PositionsAvailableX[i] == positionX)
                        {
                            PositionsAvailableX[i] = '0';
                        }
                    }

                    // clean up the array for O 
                    char[] tempPositionsAvailableO = new char[PositionsAvailableO.Length - 1];
                    int tempPositionsAvailableOi = 0;
                    for (int i = 0; i <= PositionsAvailableO.Length - 1; i++)
                    {
                        if (PositionsAvailableO[i] != '0')
                        {
                            tempPositionsAvailableO[tempPositionsAvailableOi] = PositionsAvailableO[i];
                            tempPositionsAvailableOi++;
                        }
                    }
                    PositionsAvailableO = tempPositionsAvailableO;

                    // clean up the array for X
                    char[] tempPositionsAvailableX = new char[PositionsAvailableX.Length - 1];
                    int tempPositionsAvailableXi = 0;
                    for (int i = 0; i <= PositionsAvailableX.Length - 1; i++)
                    {
                        if (PositionsAvailableX[i] != '0')
                        {
                            tempPositionsAvailableX[tempPositionsAvailableXi] = PositionsAvailableX[i];
                            tempPositionsAvailableXi++;
                        }
                    }
                    PositionsAvailableX = tempPositionsAvailableX;

                }
            }

            if (positionValidMoveKey && positionValidMoveAvailable)
            {
                positionValid = true;
            }

            return positionValid;
        }
    
        public char GetInputPositionTranslated(char playerTurn, char position)
        {
            char positionTranslated = '0';

            if (playerTurn == 'X')
            {
                switch (position)
                {
                    case 'q':
                        positionTranslated = 'i';
                        break;
                    case 'w':
                        positionTranslated = 'o';
                        break;
                    case 'e':
                        positionTranslated = 'p';
                        break;
                    case 'a':
                        positionTranslated = 'j';
                        break;
                    case 's':
                        positionTranslated = 'k';
                        break;
                    case 'd':
                        positionTranslated = 'l';
                        break;
                    case 'z':
                        positionTranslated = 'n';
                        break;
                    case 'x':
                        positionTranslated = 'm';
                        break;
                    case 'c':
                        positionTranslated = ',';
                        break;
                    default:
                        positionTranslated = '0';
                        break;
                }
            }

            if (playerTurn == 'O')
            {
                switch (position)
                {
                    case 'i':
                        positionTranslated = 'q';
                        break;
                    case 'o':
                        positionTranslated = 'w';
                        break;
                    case 'p':
                        positionTranslated = 'e';
                        break;
                    case 'j':
                        positionTranslated = 'a';
                        break;
                    case 'k':
                        positionTranslated = 's';
                        break;
                    case 'l':
                        positionTranslated = 'd';
                        break;
                    case 'n':
                        positionTranslated = 'z';
                        break;
                    case 'm':
                        positionTranslated = 'x';
                        break;
                    case ',':
                        positionTranslated = 'c';
                        break;
                    default:
                        positionTranslated = '0';
                        break;
                }
            }

            return positionTranslated;
        
        }
    }
}
