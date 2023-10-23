/* Objectives */
// (OB1) Before the game begins, ask the player whether they want to play a small, medium, or large game. Create a 4x4 world if they choose a small world, a 6x6 world if they choose a medium world, and an 8x8 world if they coose a large world.
// (OB2) Pick an appropriate location for both the Fountain Room and Entrance room.

namespace SmallMediumLarge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fountainMapPostion = 02;

            Player player = new Player();
            

            // (OB1)
            Console.WriteLine("What game size?");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("small");
            Console.WriteLine("medium");
            Console.WriteLine("large");
            Console.WriteLine();

            string sizeRequest = Console.ReadLine();
            Console.WriteLine();

            GameSize gameSize = new GameSize(sizeRequest);
            Map map = new Map(fountainMapPostion, gameSize);

            Console.WriteLine("-----------------------------------------------------------------------");
            while (!map.EndGame)
            {
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine($"You are in the room at (Row={player.PositionRow}, Column={player.PositionCol})");
                map.CheckMapPosition(player.PositionRow, player.PositionCol);

                if (player.Position != map.FountainMapPosition && !map.EndGame)
                {
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine("------------------------");
                    Console.WriteLine("move north");
                    Console.WriteLine("move east");
                    Console.WriteLine("move south");
                    Console.WriteLine("move west");
                    Console.WriteLine("------------------------");
                }
                else if (player.Position == map.FountainMapPosition && !map.EndGame)
                {
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine("------------------------");
                    Console.WriteLine("move north");
                    Console.WriteLine("move east");
                    Console.WriteLine("move south");
                    Console.WriteLine("move west");
                    Console.WriteLine("enable fountain");
                    Console.WriteLine("------------------------");
                }
                else if (map.EndGame)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You win!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                else
                {
                    throw new ArgumentException("Invalid position!");
                }

                Console.ForegroundColor = ConsoleColor.Cyan;
                string moveAction = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                player.UpdatePlayerMoveAction(moveAction, map);
                player.UpdatePlayerMapPosition(map);
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------------------------------");
            }
            Console.WriteLine("-----------------------------------------------------------------------");
        }
    }

    public class GameSize
    {
        private int[,] _size;

        public int[,] Size => _size;

        public GameSize(string size)
        {
            CreateGameSize(size);
        }

        public int[,] CreateGameSize(string size)
        {
            switch (size)
            { 
                case "small":
                    _size = new int[4, 4]
                    {
                        { 00, 01, 02, 03 },
                        { 10, 11, 12, 13 },
                        { 20, 21, 22, 23 },
                        { 30, 31, 32, 33 }
                    };
                    return _size;
                case "medium":
                    _size = new int[6, 6]
                    {
                        { 00, 01, 02, 03, 04, 05 },
                        { 10, 11, 12, 13, 14, 15 },
                        { 20, 21, 22, 23, 24, 25 },
                        { 30, 31, 32, 33, 34, 35 },
                        { 40, 41, 42, 43, 44, 45 },
                        { 50, 51, 52, 53, 54, 55 }
                    };
                    return _size;
                case "large":
                    _size = new int[8, 8]
                    {
                        { 00, 01, 02, 03, 04, 05, 06, 07 },
                        { 10, 11, 12, 13, 14, 15, 16, 17 },
                        { 20, 21, 22, 23, 24, 25, 26, 27 },
                        { 30, 31, 32, 33, 34, 35, 36, 37 },
                        { 40, 41, 42, 43, 44, 45, 46, 47 },
                        { 50, 51, 52, 53, 54, 55, 56, 57 },
                        { 60, 61, 62, 63, 64, 65, 66, 67 },
                        { 70, 71, 72, 73, 74, 75, 76, 77 }
                    };
                    return _size;
                default:
                    throw new ArgumentException("Invalid game size provided.");
            }
        }
    }
    public class Player
    {
        public Direction MoveDirection { get; set; }
        public int PositionRow { get; set; }
        public int PositionCol { get; set; }
        public int Position { get; set; }

        public Player()
        {
            PositionRow = 0;
            PositionCol = 0;
        }

        public void UpdatePlayerMoveAction(string moveAction, Map map)
        {


            if (this.Position == map.FountainMapPosition)
            {
                switch (moveAction)
                {
                    case "move north":
                        MoveDirection = Direction.North;
                        break;
                    case "move east":
                        MoveDirection = Direction.East;
                        break;
                    case "move south":
                        MoveDirection = Direction.South;
                        break;
                    case "move west":
                        MoveDirection = Direction.West;
                        break;
                    case "enable fountain":
                        MoveDirection = Direction.None;
                        map.IsFountainEnabled = true;
                        break;
                    default:
                        Console.WriteLine("Not a valid action!");
                        break;
                }
            }
            else
            {
                switch (moveAction)
                {
                    case "move north":
                        MoveDirection = Direction.North;
                        break;
                    case "move east":
                        MoveDirection = Direction.East;
                        break;
                    case "move south":
                        MoveDirection = Direction.South;
                        break;
                    case "move west":
                        MoveDirection = Direction.West;
                        break;
                    default:
                        Console.WriteLine("Not a valid direction!");
                        break;
                }
            }

        }

        public void UpdatePlayerMapPosition(Map map)
        {
            bool validMapPosition = map.ValidMapPosition(PositionRow, PositionCol, MoveDirection);

            if (validMapPosition)
            {
                switch (MoveDirection)
                {
                    case Direction.North:
                        PositionRow--;
                        break;
                    case Direction.East:
                        PositionCol++;
                        break;
                    case Direction.South:
                        PositionRow++;
                        break;
                    case Direction.West:
                        PositionCol--;
                        break;
                    case Direction.None:
                        break;
                }
            }

            string positionStr = $"{Convert.ToString(PositionRow)}{Convert.ToString(PositionCol)}";

            int position = Convert.ToInt32(positionStr);

            Position = position;
        }
    }

    public class Map
    {
        public int[,] map;

        public int FountainMapPosition { get; init; }
        public int EntranceMapPosition { get; init; }
        public bool IsFountainEnabled { get; set; }
        public bool EndGame { get; set; } = false;

        public Map(int fountainMapPosition, GameSize gameSize)
        {
            map = gameSize.Size;

            EntranceMapPosition = 00;
            FountainMapPosition = fountainMapPosition;
            IsFountainEnabled = false;
        }

        public bool ValidMapPosition(int currentPositionRow, int currentPositionCol, Direction requestedMoveDirection)
        {
            try
            {
                bool positionValid = false;
                int requestedPositionRow = 0;
                int requestedPositionCol = 0;
                string requestedPositionStr = "00";
                int requestedPosition = 00;

                switch (requestedMoveDirection)
                {
                    case Direction.North:
                        requestedPositionRow = --currentPositionRow;
                        break;
                    case Direction.East:
                        requestedPositionCol = ++currentPositionCol;
                        break;
                    case Direction.South:
                        requestedPositionRow = ++currentPositionRow;
                        break;
                    case Direction.West:
                        requestedPositionCol = --currentPositionCol;
                        break;
                }

                requestedPositionStr = $"{Convert.ToString(requestedPositionRow)}{Convert.ToString(requestedPositionCol)}";

                requestedPosition = Convert.ToInt32(requestedPositionStr);

                for (int row = 0; row < map.GetLength(0); row++)
                {
                    for (int col = 0; col < map.GetLength(1); col++)
                    {
                        int mapPosition = map[row, col];


                        if (requestedPositionRow == mapPosition)
                        {
                            positionValid = true;
                            break;
                        }
                    }

                    if (positionValid)
                    {
                        break;
                    }
                }

                return positionValid;
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("map value does not exist!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("unknown error");
            }

            return false;
        }
        public void CheckMapPosition(int positionRow, int positionCol)
        {
            int position;
            string positionStr;
            string positionEntrance = "00";
            string positionFountain = "02";

            positionStr = $"{Convert.ToString(positionRow)}{Convert.ToString(positionCol)}";

            if ((positionStr == positionEntrance) && !IsFountainEnabled)
            {
                Console.WriteLine("You see light comming from the cavern entrance.");
            }
            else if ((positionStr == positionEntrance) && IsFountainEnabled)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("The Fountain of Objects has been reactivated, you have escaped with your life!");
                EndGame = true;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if ((positionStr == positionFountain) && IsFountainEnabled)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("You hear the rushing waters from the Fountain of Objects. It has been reactivated!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (positionStr == positionFountain)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("You hear water dripping in this room. The Fountain of Objects is here!");
                Console.ForegroundColor = ConsoleColor.White; ;
            }
        }
    }

    public enum Direction
    {
        North,
        East,
        South,
        West,
        None
    }
}

