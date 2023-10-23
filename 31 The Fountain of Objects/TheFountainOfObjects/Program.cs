/* Objectives */
// The world consists of a grid of rooms, where each room can be referenced by its row and column. North is up, east is right, south is down, and west is left.
// The game's flow works like this: The player is told what they can sense in the dark. Then the player gets a chance to perform some action by typing it in. Their chosen action is resolved (the player moves, state of things in the game changes, checking for a win or loss, etc.) Then the loop repeats.
// Most rooms are empty rooms, and there is nothing to sense.
// The player is in one of the rooms and can move between them by typing commands like the following: "move north", "move south", "move east", and "move west". The player should not be able to move past the end of the map. ✓
// The room at (Row=0, Column=0) is the cavern entrance (and exit). The player start here. The player can sense light comming from outside the cavern when in this room. ("You see light in this room coming from outside the cavern. This is the entrace.")
// The room at (Row=0, Column=2) is the fountain room, containing the Fountain of Objects iteself. The Fountain can either be enabled or disabled. The player can hear the fountain but hears different things depending on if it is on or not. ("You hear water dripping in this room. The Fountain of Objects is here!" or "You hear the rushing water from the Fountain of Objects. It has been reactivated!") The fountain is off initially. In the fountain room, the player can type "enable fountain" to enable it. If the player is not in the fountain room and runs this, there should be no effect, and the player should be told so.
// The player wins by moving to the fountain room, enabling the Fountain of Objects, and moving back to the cavern entrance. If the player is in the entrance and the fountain is on, the player wins.
// Use different colors to display the different types of text in the console window. For example, narrative items (intro, ending, etc.) may be magenta, descriptive text in white, input from the user in cyan, text describing entrance light in yellow, messages about the fountain in blue.

using System.Data;
using System.Numerics;

namespace TheFountainOfObjects
{
    // The player is in one of the rooms and can move between them by typing commands like the following: "move north", "move south", "move east", and "move west". The player should not be able to move past the end of the map.
    internal class Program
    {
        static void Main(string[] args)
        {
            int fountainMapPostion = 02;

            Player player = new Player();
            Map map = new Map(fountainMapPostion);

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

    // The room at (Row=0, Column=2) is the fountain room, containing the Fountain of Objects iteself. The Fountain can either be enabled or disabled. The player can hear the fountain but hears different things depending on if it is on or not. ("You hear water dripping in this room. The Fountain of Objects is here!" or "You hear the rushing water from the Fountain of Objects. It has been reactivated!") The fountain is off initially. In the fountain room, the player can type "enable fountain" to enable it. If the player is not in the fountain room and runs this, there should be no effect, and the player should be told so.
    public class Map
    {
        public int[,] map;

        public int FountainMapPosition { get; init; }
        public int EntranceMapPosition { get; init; }
        public bool IsFountainEnabled { get; set; }
        public bool EndGame {get; set;} = false;

        public Map(int fountainMapPosition)
        {
            map = new int[4, 4]
            {
                { 00, 01, 02, 03 },
                { 10, 11, 12, 13 },
                { 20, 21, 22, 23 },
                { 30, 31, 32, 33 }
            };

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
