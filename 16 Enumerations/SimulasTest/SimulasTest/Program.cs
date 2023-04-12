using SimulasTest;

bool chest = true;

/* Make a variable whose type is this new enumeration */
Chest currentChestState = Chest.Locked;
string requestChestState;
string currentChestStatus = "locked";

/* Write code to allow you to manipulate the chest with
 * lock, unlock, open, and close commands,
 * but ensure that don't transition between
 * states that don't support it */
Chest UpdateChestLock(string chestUpdateRequest)
{
    // Chest is Open
    if(currentChestState == Chest.Open)
    {
        if (chestUpdateRequest == "close")
        {
            currentChestStatus = "closed";
            return currentChestState = Chest.Closed;
        }
        else if (requestChestState == "lock")
        {
            currentChestStatus = "open";
            return currentChestState = Chest.Open;
        }
        else if (requestChestState == "unlock")
        {
            currentChestStatus = "open";
            return currentChestState = Chest.Open;
        }
        else if (requestChestState == "open")
        {
            currentChestStatus = "open";
            return currentChestState = Chest.Open;
        }
        else
        {
            currentChestStatus = "locked";
            return currentChestState = Chest.Locked;
        }
    }
    // Chest is Closed
    else if (currentChestState == Chest.Closed)
    {
        if (chestUpdateRequest == "close")
        {
            currentChestStatus = "closed";
            return currentChestState = Chest.Closed;
        }
        else if (requestChestState == "lock")
        {
            currentChestStatus = "locked";
            return currentChestState = Chest.Locked;
        }
        else if (requestChestState == "unlock")
        {
            currentChestStatus = "closed";
            return currentChestState = Chest.Closed;
        }
        else if (requestChestState == "open")
        {
            currentChestStatus = "open";
            return currentChestState = Chest.Open;
        }
        else
        {
            currentChestStatus = "locked";
            return currentChestState = Chest.Locked;
        }
    }
    // Chest is Locked
    else if (currentChestState == Chest.Locked)
    {
        if (chestUpdateRequest == "close")
        {
            currentChestStatus = "locked";
            return currentChestState = Chest.Locked;
        }
        else if (requestChestState == "lock")
        {
            currentChestStatus = "locked";
            return currentChestState = Chest.Locked;
        }
        else if (requestChestState == "unlock")
        {
            currentChestStatus = "unlocked";
            return currentChestState = Chest.Closed;
        }
        else if (requestChestState == "open")
        {
            currentChestStatus = "locked";
            return currentChestState = Chest.Locked;
        }
        else
        {
            currentChestStatus = "locked";
            return currentChestState = Chest.Locked;
        }
    }
    else
    {
        currentChestStatus = "locked";
        return currentChestState = Chest.Locked;
    }    
}


/* Loop forever, asking for the next command. */
while (chest)
{
    string currentRequest;

    Console.Write($"The chest is {currentChestStatus} ");
    Console.Write($"What do you want to do? ");
    requestChestState = Convert.ToString(Console.ReadLine());
    currentChestState = UpdateChestLock(requestChestState);
}
