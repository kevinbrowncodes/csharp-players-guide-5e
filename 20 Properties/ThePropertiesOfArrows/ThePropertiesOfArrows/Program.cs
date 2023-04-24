using ThePropertiesOfArrows;
using VinFletchersArrow;

Arrowhead arrowhead;
int shaft = 0;
Fletching fletching;

/* Allow a user to pick the arrowhead, fletching, and length 
 * and then create a new Arrow instance */
// pick a arrowhead
Console.WriteLine($"Pick an arrowhead: " +
                    $"{Arrowhead.Steel}, " +
                    $"{Arrowhead.Wood}, " +
                    $"{Arrowhead.Obsidian}");
string strArrowhead = Console.ReadLine();
arrowhead = (Arrowhead)Enum.Parse(typeof(Arrowhead), strArrowhead);

// pick a shaft
while (shaft < 60 || shaft > 100)
{
    Console.WriteLine($"Pick a shaft between 60cm and 100cm: ");
    shaft = Convert.ToInt32(Console.ReadLine());
}

// pick a fletching
Console.WriteLine($"Pick a fletching: " +
                    $"{Fletching.Plastic}, " +
                    $"{Fletching.Turkey}, " +
                    $"{Fletching.Goose}");
string strFletching = Console.ReadLine();
fletching = (Fletching)Enum.Parse(typeof(Fletching), strFletching);

Arrow arrow = new Arrow(arrowhead, shaft, fletching);

// making the arrow field private prevents updating arrow's length
// arrow.length = 60;

// costArrow = arrow.GetCost(arrow);

Console.WriteLine($"\nThe cost of the arrow is ${arrow.GetCost()} gold.");

/* Validation */
// Arrowhead = Wood = 3
// Length = 60 => (60 * .05) => 3
// Fletching = Goose = 3
// Cost = 9