using ThePoint;

int coordXInput;
int coordYInput;
Point point;

coordXInput = 2;
coordYInput = 3;

point = new Point(coordXInput, coordYInput);

Console.WriteLine($"({point.CoordX},{point.CoordY})");

coordXInput = -4;
coordYInput = 0;

point = new Point(coordXInput, coordYInput);

Console.WriteLine($"({point.CoordX},{point.CoordY})");

/* Questions */
// Are your X and Y properties immutable? Why did you choose what you did?
/// Yes, my X and Y properties are immutable since they cannot be changed.