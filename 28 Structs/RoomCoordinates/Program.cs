using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace RoomCoordinates
{
    internal class Program
    { 
        /* Write a main method that creates a few coordinates and determines if they are adjacent to each other
        * to provide that it is working correctly. */
        static void Main(string[] args)
        {
            Coordinate coord1 = new Coordinate(0, 0);
            Coordinate coord2 = new Coordinate(0, 1);
            Coordinate coord3 = new Coordinate(1, 0);
            Coordinate coord4 = new Coordinate(1, 1);
            Coordinate coord5 = new Coordinate(0, -1);
            Coordinate coord6 = new Coordinate(-1, 0);
            Coordinate coord7 = new Coordinate(-1, -1);

            Console.WriteLine($"Coordinate 1: {coord1.CordX},{coord1.CordY}");
            Console.WriteLine($"Coordinate 2: {coord2.CordX},{coord2.CordY}");
            Console.WriteLine($"Coordinate 3: {coord3.CordX},{coord3.CordY}");
            Console.WriteLine($"Coordinate 4: {coord4.CordX},{coord4.CordY}");
            Console.WriteLine($"Coordinate 5: {coord5.CordX},{coord5.CordY}");
            Console.WriteLine($"Coordinate 6: {coord6.CordX},{coord6.CordY}");
            Console.WriteLine($"Coordinate 7: {coord7.CordX},{coord7.CordY}");

            Console.WriteLine("\nIs Coordinate 1 next to Coordinate 2?: " + Coordinate.CheckSide(coord1, coord2));
            Console.WriteLine("\nIs Coordinate 1 next to Coordinate 3?: " + Coordinate.CheckSide(coord1, coord3));
            Console.WriteLine("\nIs Coordinate 1 next to Coordinate 4?: " + Coordinate.CheckSide(coord1, coord4));
            Console.WriteLine("\nIs Coordinate 1 next to Coordinate 5?: " + Coordinate.CheckSide(coord1, coord5));
            Console.WriteLine("\nIs Coordinate 1 next to Coordinate 6?: " + Coordinate.CheckSide(coord1, coord6));
            Console.WriteLine("\nIs Coordinate 1 next to Coordinate 7?: " + Coordinate.CheckSide(coord1, coord7));

        }


    }
    /* Create a Coordinate struct that can represent a room coordinate with a row and column */
    /* Ensure Coordinate is immutable */
    public struct Coordinate
    {
        public int CordX { get; init; }
        public int CordY { get; init; }

        public Coordinate(int coordX, int coordY)
        {
            CordX = coordX;
            CordY = coordY;
        }

        /* Make a method to determine if one coordinate is adjacent to another (differing only by a single row 
         * or column */
        public static bool CheckSide(Coordinate checkCord1, Coordinate checkCord2)
        {
            bool isSide = false;

            // possible adjacent coords for checkCord1
            Coordinate possibleCoordinate1;
            Coordinate possibleCoordinate2;
            Coordinate possibleCoordinate3;
            Coordinate possibleCoordinate4;
            possibleCoordinate1 = new Coordinate(checkCord1.CordX - 1, checkCord1.CordY + 0);
            possibleCoordinate2 = new Coordinate(checkCord1.CordX + 1, checkCord1.CordY + 0);
            possibleCoordinate3 = new Coordinate(checkCord1.CordX + 0, checkCord1.CordY - 1);
            possibleCoordinate4 = new Coordinate(checkCord1.CordX + 0, checkCord1.CordY + 1);

            Coordinate[] possibleCoordinates = new Coordinate[] { possibleCoordinate1, possibleCoordinate2, possibleCoordinate3, possibleCoordinate4 };

            foreach (Coordinate possibleCoordinate in possibleCoordinates)
            {
                if (checkCord2.CordX == possibleCoordinate.CordX && checkCord2.CordY == possibleCoordinate.CordY)
                {
                    isSide = true;
                    break;
                }
            }

            return isSide;
        }

    }
} 