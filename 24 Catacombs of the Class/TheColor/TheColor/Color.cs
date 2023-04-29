namespace TheColor
{
	/* Define a new Color class with properties for its red, green, and blue channels */
	public class Color
	{
		// fields
		private int _r;
		private int _g;
		private int _b;

		// constructors
		public Color()
		{
			_r = 0;
			_g = 0;
			_b = 0;
		}

		public Color(int red, int green, int blue)
		{
			_r = red;
			_g = green;
			_b = blue;
		}

		// properties
		public int R
		{
			get
			{
				return _r;
			}
		}

		public int G
		{
			get
			{
				return _g;
			}
		}

		public int B
		{
			get
			{
				return _b;
			}
		}
		/* create static properties to define eight colors */
		// White
		public static Color White { get; } = new Color(255, 255, 255);
		// Black
		public static Color Black { get; } = new Color(0, 0, 0);
		// Red
		public static Color Red { get; } = new Color(255, 0, 0);
		// Orange
		public static Color Orange { get; } = new Color(255, 165, 0);
		// Yellow
		public static Color Yellow {get;} = new Color(255, 255, 0);
		// Green
		public static Color Green { get; } = new Color(0, 128, 0);
		// Blue
		public static Color Blue { get; } = new Color(0, 0, 255);
		// Purple
		public static Color Purple { get; } = new Color(128, 0, 128);
    }
}

