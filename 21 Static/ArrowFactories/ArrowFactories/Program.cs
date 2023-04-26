using ArrowFactories;

Arrow arrow;
Arrowhead arrowhead;
int shaft = 0;
Fletching fletching;
bool standardArrow = false;

/* Modify the program to allow users to choose one of the pre-defined types
 * ot a custom arrow */
Console.WriteLine("Choose Arrow Type: ");
Console.WriteLine("Standard");
Console.WriteLine("Custom");
Console.WriteLine();
string arrowType = Console.ReadLine();

if(arrowType == "Standard")
{
    standardArrow = true;
}

if(standardArrow) {
    Console.WriteLine("\nChoose Arrow Type: ");
    Console.WriteLine("Beginner");
    Console.WriteLine("Marksman");
    Console.WriteLine("Elite");
    Console.WriteLine();
    string arrowTypeStandard = Console.ReadLine();

    switch(arrowTypeStandard){
        // Beginner Arrow
        case "Beginner":
            arrow = Arrow.CreateBeginnerArrow();
            Console.WriteLine($"\nThe cost of the arrow is ${arrow.GetCost()} gold.");
            break;
        // Marksman Arrow
        case "Marksman":
            arrow = Arrow.CreateMarksmanArrow();
            Console.WriteLine($"\nThe cost of the arrow is ${arrow.GetCost()} gold.");
            break;
        // Elite Arrow
        case "Elite":
            arrow = Arrow.CreateEliteArrow();
            Console.WriteLine($"\nThe cost of the arrow is ${arrow.GetCost()} gold.");
            break;
        default:
            Console.WriteLine("An error has occured!");
            break;
    }
    
}
else {
    // pick a arrowhead
    Console.WriteLine($"\nPick an arrowhead: " +
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

    arrow = new Arrow(arrowhead, shaft, fletching);

    Console.WriteLine($"\nThe cost of the arrow is ${arrow.GetCost()} gold.");
}

/* Validation */
// Standard
// Beginner Arrow = $9.75
// Marksman Arrow = $16.25
// Elite Arrow = $24.75
// Custom
// Custom Arrow 1 (Wood, 60, Goose) = $9