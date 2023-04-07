string menu;
string menuItem1 = "Rope";
string menuItem2 = "Torches";
string menuItem3 = "Climbing Equipment";
string menuItem4 = "Clean Water";
string menuItem5 = "Machete";
string menuItem6 = "Canoe";
string menuItem7 = "Food Supplies";

double costItemFood = 1;
double costItemWater = 1;
double costItemRope = 10;
double costItemTorches = 15;
double costItemMachete = 20;
double costItemClimbingEquipment = 25;
double costItemCanoe = 200;
double numItemInput;

string response;

string strName;
string strHero = "Kevin";
double discountAmount = .50;

/* Modify Buying Inventory program */
#region
Console.WriteLine("What is your name? ");
strName = Console.ReadLine();


menu = "The following items are available: \n" +
            "1 - Rope \n" +
            "2 - Torches \n" +
            "3 - Climbing Equipment \n" +
            "4 - Clean Water \n" +
            "5 - Machete \n" +
            "6 - Canoe \n" +
            "7 - Food Supplies";

Console.WriteLine(menu);

Console.WriteLine("Enter a number from the menu: ");
numItemInput = Convert.ToInt32(Console.ReadLine());

if (strName != strHero)
{
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
}
else if (strName == strHero)
{
    response = numItemInput switch
    {
        1 => $"{menuItem1} cost {costItemRope * discountAmount} gold.",
        2 => $"{menuItem2} cost {costItemTorches * discountAmount} gold.",
        3 => $"{menuItem3} cost {costItemClimbingEquipment * discountAmount} gold.",
        4 => $"{menuItem4} cost {costItemWater * discountAmount} gold.",
        5 => $"{menuItem5} cost {costItemMachete * discountAmount} gold.",
        6 => $"{menuItem6} cost {costItemCanoe * discountAmount} gold.",
        7 => $"{menuItem7} cost {costItemFood * discountAmount} gold.",
        _ => $"An Error has occured!",
    };
}
else
{
    response = "An Error has occured!";
}

Console.WriteLine(response);
#endregion
