int num;
string word;

/* Take a number as input from the console */
#region
Console.WriteLine("Input number: ");
num = Convert.ToInt32(Console.ReadLine());
#endregion

/* Display the word "Tick" if the number is even. 
 * Display the word "Tock" if the number is odd. */
#region
if (num % 2 == 0)
{
    word = "Tick";
}
else if (num % 2 > 0)
{
    word = "Tock";
}
else
{
    word = "Error!";
}

Console.WriteLine(word);
#endregion
