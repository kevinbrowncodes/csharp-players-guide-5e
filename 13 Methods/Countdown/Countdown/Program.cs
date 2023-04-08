int numInput = 10;

/* A countdown loop */
for(int x = numInput; x > 0; x--)
{
    Console.WriteLine(x);
}

/* A countdown loop with no loops */
Countdown(numInput);

void Countdown(int numInput)
{
    // base case
    if(numInput == 0)
    {
        return;
    }

    Console.WriteLine(numInput);
    numInput--;
    Countdown(numInput);
}