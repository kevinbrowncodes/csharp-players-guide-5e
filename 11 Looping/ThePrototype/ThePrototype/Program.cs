int numLocationPilot = -1;
int numGuessHero = -1;
string response = "";

/* Build a program that will allow a user, the pilot, to enter a number. */
#region
/* If the number is above 100 or less than 0, keep asking. */
#region
while (numLocationPilot <= 0 || numLocationPilot >= 100)
{
    Console.WriteLine("User 1, you are the pilot enter a number between 0 and 100: ");
    numLocationPilot = Convert.ToInt32(Console.ReadLine());
    if (numLocationPilot >= 0 && numLocationPilot <= 100)
    {
        break;
    }
}
#endregion
#endregion

/* Clear the screen once the program has collected a good number. */
#region
Console.Clear();
#endregion

/* Ask a second user, the hunter, to guess numbers. */
/* Indicate whether the user guessed too high, too low, or guessed right */
/* Loop until they get it right, then end the program */
#region
while (numGuessHero <= 0 || numGuessHero >= 100)
{
    if (numGuessHero <= 0 || numGuessHero >= 100)
    {
        Console.WriteLine("User 2, you are the hero guess a number between 0 and 100.");
        numGuessHero = Convert.ToInt32(Console.ReadLine());

        if (numGuessHero == numLocationPilot)
        {
            response = "You guess the number!";
            Console.WriteLine(response);
            break;
        }
    }

    while (numGuessHero != numLocationPilot)
    {
        Console.WriteLine("What is your next guess?");
        numGuessHero = Convert.ToInt32(Console.ReadLine());

        if (numGuessHero == numLocationPilot)
        {
            response = "You guess the number!";
            Console.WriteLine(response);
            break;
        }
        else if (numGuessHero < numLocationPilot)
        {
            response = $"{numGuessHero} is too low.";
            Console.WriteLine(response);
            continue;
        }
        else if (numGuessHero > numLocationPilot)
        {
            response = $"{numGuessHero} is too high.";
            Console.WriteLine(response);
            continue;
        }
        else
        {
            response = "An error has occured!";
            Console.WriteLine(response);
            break;
        }

    }

    break;

}
#endregion


