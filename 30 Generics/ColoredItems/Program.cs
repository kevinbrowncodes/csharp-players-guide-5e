namespace ColoredItems
{
    internal class Program
    {
        /* In your main method, create a new colored item containing a blue sword, a red bow, and a green axe. Display all three items to see each item displayed in its color */
        static void Main(string[] args)
        {
            Sword sword = new Sword();
            ColoredItem<Sword> blueSword = new ColoredItem<Sword>(sword, "blue");
            blueSword.Display();

            Bow bow = new Bow();
            ColoredItem<Bow> redBow = new ColoredItem<Bow>(bow, "red");
            redBow.Display();

            Axe axe = new Axe();
            ColoredItem<Axe> greenAxe = new ColoredItem<Axe>(axe, "green");
            greenAxe.Display();


        }
    }

    /* Put the three class definitions above into a new project */
    public class Sword { }
    public class Bow { }
    public class Axe { }

    /* Define a generic class to represent a color item. It must have properties for the item itself (generic in type) and a ConsoleColor associated with */
    public class ColoredItem<T>
    {
        // property
        private T Item { get; set; }
        private ConsoleColor Color { get; set; }

        // constructor
        public ColoredItem(T item, string color)
        { 

            Item = item;
            if (Enum.TryParse(color, true, out ConsoleColor consoleColor))
            {
                Color = consoleColor;
            }
            else
            {
                Color = ConsoleColor.White;
            }

        }

        // method
        /* Add a void Display() method to your colored item type that changes the console's foreground color to the item's color and display the item in that color. (Hint: It is sufficient to just call ToString() on the item to get a text representation */
        public void Display() 
        { 
            Console.ForegroundColor = Color;
            Console.WriteLine(Item);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}