/* Establish the game's starting state */
int numAirshipPosition;
int numCityHP = 15;
int numAirshipHP = 10;
int numGameRound = 1;

/* Ask the first player (The Uncoded One) to choose the Manticore's distance from the city */
Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
numAirshipPosition = Convert.ToInt32(Console.ReadLine());
Console.Clear();

/* Run the game in a loop until either the Manticore's or city's health reaches 0. */
/* Before the second player's turn, display the round number, the city's health, and the Manticore's health */
Console.WriteLine("Player 2, it is your turn.");
Console.WriteLine("--------------------------------------------");

while(numCityHP != 0)
{
    int currentCannonDamge;
    string hitMessage;

    Console.WriteLine($"STATUS: Round {numGameRound} City: {numCityHP}/15 Manticore {numAirshipHP}/10");
    currentCannonDamge = calculateCannonDamage(numGameRound);
    Console.WriteLine($"The cannon is expected to deal {currentCannonDamge} damange this round.");

    /* Get target range from the second player and resolve its effect */
    Console.Write("Enter desired cannon range: ");
    int numCannonRange = Convert.ToInt32(Console.ReadLine());
    updateNumAirshipHP(numCannonRange, currentCannonDamge);
    hitMessage = getHitMessage(numCannonRange);

    Console.WriteLine(hitMessage);

    /* If the Manticore is still alive, resuce the city's health by 1 */
    if (numAirshipHP > 1)
    {
        numCityHP--;
    }

    /* When the Manticore or the city's health reaches 0, end the game and display the outcome */
    if (numAirshipHP <= 0) {
        Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
        break;
    }
    else if (numCityHP <= 0) {
        Console.WriteLine("The city of Consolas has been destroyed!");
        break;
    }

    /* Advance to the next round */
    Console.WriteLine("--------------------------------------------");
    numGameRound++;
}

/* Computer how much damage the cannon will deal this round: 10 points if the round number is a multiple of
 * both 3 and 5, 3 if it is a multuple of 3 or 5, and 1 otherwise. Display this to the player */
int calculateCannonDamage(int currentNumGameRound)
{
    int calculatedCannonDamage;

    if(currentNumGameRound%3 == 0 && currentNumGameRound % 5 == 0)
    {
        calculatedCannonDamage = 10;
    }
    else if (currentNumGameRound % 3 == 0)
    {
        calculatedCannonDamage = 3;
    }
    else if (currentNumGameRound % 5 == 0)
    {
        calculatedCannonDamage = 3;
    }
    else
    {
        calculatedCannonDamage = 1;
    }

    return calculatedCannonDamage;
}

void updateNumAirshipHP(int numCurrentCannonRange, int numCurrentCannonDamge)
{
    if (numAirshipPosition == numCurrentCannonRange)
    {
        numAirshipHP -= numCurrentCannonDamge;
    }

    if (numAirshipHP < 0)
    {
        numAirshipHP = 0;
    }
}

string getHitMessage(int numCurrentCannonRange)
{
    string currentHitMessage;

    if (numAirshipPosition > numCurrentCannonRange)
    {
        currentHitMessage = "That round FELL SHORT the target.";
    }
    else if (numAirshipPosition == numCurrentCannonRange)
    {
        currentHitMessage = "That round was a DIRECT HIT!";
    }
    else if (numAirshipPosition < numCurrentCannonRange)
    {
        currentHitMessage = "That round OVERSHOT the target.";
    }
    else
    {
        currentHitMessage = "An error has occured!";
    }


    return currentHitMessage;
}