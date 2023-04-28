using System;
namespace ThePoint
{
	/* Define a new Point class with properties for X and Y */
	public class Point
	{
		private int _coordX;
		private int _coordY;


		/* Add a parameterless constructor to create a point at origin (0,0); */
		public Point()
		{
			_coordX = 0;
            _coordY = 0;
        }


		/* Add a constructor to create a point from a specific x- and y- coordinate */
        public Point(int coordX, int coordY)
		{
			_coordX = coordX;
			_coordY = coordY;
		}

        // properties
        public int CoordX
		{
			get
			{
				return _coordX;
			}
			set
			{
				_coordX = value;

            }
		}

		public int CoordY
		{
			get
			{
				return _coordY;
			}
			set
			{
				_coordY = value;
            }
		}
    }
}

