int crdX;
int crdY;
string direction;

/* Ask the user for x value and y value */
#region
Console.WriteLine("What is X? ");
crdX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What is Y? ");
crdY = Convert.ToInt32(Console.ReadLine());
#endregion

/* Display a message about what direction the enemy is comming from */
#region
if (crdX < 0)
{
    if(crdY < 0)
    {
        direction = "southwest";
    }
    else if(crdY == 0)
    {
        direction = "west";
    }
    else if (crdY > 0)
    {
        direction = "northwest";
    }
    else
    {
        direction = "an error has occured!";
    }
}
else if(crdX == 0)
{
    if (crdY < 0)
    {
        direction = "south";
    }
    else if (crdY == 0)
    {
        direction = "here";
    }
    else if (crdY > 0)
    {
        direction = "north";
    }
    else
    {
        direction = "an error has occured!";
    }
}
else if(crdX > 0)
{
    if (crdY < 0)
    {
        direction = "southeast";
    }
    else if (crdY == 0)
    {
        direction = "east";
    }
    else if (crdY > 0)
    {
        direction = "northeast";
    }
    else
    {
        direction = "an error has occured!";
    }
}
else
{
    direction = "an error has occured!";
}

Console.WriteLine($"The enemy is {direction}!");
#endregion