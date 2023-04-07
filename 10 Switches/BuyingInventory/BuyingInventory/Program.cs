string menu;
string menuItem1 = "Rope";
string menuItem2 = "Torches";
string menuItem3 = "Climbing Equipment";
string menuItem4 = "Clean Water";
string menuItem5 = "Machete";
string menuItem6 = "Canoe";
string menuItem7 = "Food Supplies";

int cost;
int costItemFood = 1;
int costItemWater = 1;
int costItemRope = 10;
int costItemTorches = 15;
int costItemMachete = 20;
int costItemClimbingEquipment = 25;
int costItemCanoe = 200;
int numItemInput;

string response;

/* Build a program that will show the menu */
#region
menu = "The following items are available: \n" +
            "1 - Rope \n" +
            "2 - Torches \n" +
            "3 - Climbing Equipment \n" +
            "4 - Clean Water \n" +
            "5 - Machete \n" +
            "6 - Canoe \n" +
            "7 - Food Supplies";

Console.WriteLine(menu);
#endregion

/* Ask the user to enter a number from the menu */
#region
Console.WriteLine("Enter a number from the menu: ");
numItemInput = Convert.ToInt32(Console.ReadLine());
#endregion


/* Use a switch to show the item's cost */
#region
response = numItemInput switch
{
    1 => $"{menuItem1} cost {costItemRope} gold.",
    2 => $"{menuItem2} cost {costItemTorches} gold.",
    3 => $"{menuItem3} cost {costItemClimbingEquipment} gold.",
    4 => $"{menuItem4} cost {costItemWater} gold.",
    5 => $"{menuItem5} cost {costItemMachete} gold.",
    6 => $"{menuItem6} cost {costItemCanoe} gold.",
    7 => $"{menuItem7} cost {costItemFood} gold.",
    _ => $"An Error has occured!",
};

Console.WriteLine(response);
#endregion
