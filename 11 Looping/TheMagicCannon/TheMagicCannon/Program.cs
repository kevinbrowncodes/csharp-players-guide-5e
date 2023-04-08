/* Write a program that will loop through the values between 1 and 100 and display what kind of blast the crew should exepct. */
for (int i = 1; i <= 100; i++)
{
    Console.ForegroundColor = ConsoleColor.White;

    // when the two line up, it generates a potent combined blast
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine($"{i}: Blast");
        continue;
    }

    // every third turn, the fire gem activates
    if (i%3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{i}: Fire");
        continue;
    }

    // every fifth turn, the electric gem activates
    if (i%5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{i}: Electric");
        continue;
    }

    Console.WriteLine($"{i}: Normal");
}