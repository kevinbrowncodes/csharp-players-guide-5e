using TheColor;

/* make two Color-types variables */
Color colorRandom;
Color colorFixed;

/* use a constructor to create a color instance 
 * and use a static property for the other */
colorRandom = new Color(1, 1, 1);
colorFixed = Color.Yellow;

/* display each of their red, green, and blue
 * channels */
Console.WriteLine("Color 1");
Console.WriteLine($"R:{colorRandom.R} G:{colorRandom.G} B:{colorRandom.B}");
Console.WriteLine("Color 2");
Console.WriteLine($"R:{colorFixed.R} G:{colorFixed.G} B:{colorFixed.B}");