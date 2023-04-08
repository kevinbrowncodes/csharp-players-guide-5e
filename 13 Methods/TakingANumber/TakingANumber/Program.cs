/* method with signature int AskForNumber(string text) */
#region
int resultNum = AskForNumber("What is the airspeed velocity of an unladen swallow?");
Console.WriteLine("The airspeed velocity of an unladen swallow is " + resultNum + "mph." + "\n");

int AskForNumber(string ask) {
    Console.WriteLine(ask);
    int response = Convert.ToInt32(Console.ReadLine());

    return response;
}
#endregion

/* method with signature int AskForNumberInRange(string text, int min, int max) */
#region
int resultNumInRange = AskForNumberInRange("What is number in range:", 50, 100);
Console.WriteLine(resultNumInRange + " is within range.");

int AskForNumberInRange(string text, int min, int max){
    int numRangeInput;

    Console.WriteLine($"{text} ({min},{max})");
    numRangeInput = Convert.ToInt32(Console.ReadLine());

    while(!(numRangeInput >= min && numRangeInput <= 100))
    {
        Console.WriteLine($"{text} ({min},{max})");
        numRangeInput = Convert.ToInt32(Console.ReadLine());

        if((numRangeInput >= min && numRangeInput <= 100))
        {
            break;
        }
    }

    return numRangeInput;
}
#endregion