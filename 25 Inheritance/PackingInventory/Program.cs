namespace PackingInventory
{
    internal class Program
    {          
        /* Add properties to the Pack that allow it to report the current item count, weight, and volume, and the limits of each */
        /* Createa a program that creates a new pack and then allow the user to add (or attempt to add) items chosen from a menu */
        static void Main(string[] args)
        {
            string itemInput;
            InventoryItem inventoryItem;

            Pack pack = new Pack(10, 20, 30);

            while (!pack.Full)
            {
                Console.WriteLine("\nBag status");
                Console.WriteLine($"Max Count: {pack.MaxCount} Current Count: {pack.CurrentCount}");
                Console.WriteLine($"Max Weight: {pack.MaxWeight} Current Weight: {pack.CurrentWeight}");
                Console.WriteLine($"Max Volume: {pack.MaxVolume} Current Volume: {pack.CurrentVolume}");

                Console.WriteLine("\nWhat do you want to pack?");
                Console.WriteLine("SELECTION\tITEM\tWEIGHT\tVolume");
                Console.WriteLine("1\t\tarrow\t0.1\t0.05");
                Console.WriteLine("2\t\tbow");
                Console.WriteLine("3\t\trope");
                Console.WriteLine("4\t\twater");
                Console.WriteLine("5\t\tfood");
                Console.WriteLine("6\t\tsword");
                itemInput = Console.ReadLine();
                switch (itemInput)
                {
                    case "1":
                        inventoryItem = new Arrow();
                        break;
                    case "2":
                        inventoryItem = new Bow();
                        break;
                    case "3":
                        inventoryItem = new Rope();
                        break;
                    case "4":
                        inventoryItem = new Water();
                        break;
                    case "5":
                        inventoryItem = new Food();
                        break;
                    case "6":
                        inventoryItem = new Sword();
                        break;
                    default:
                        inventoryItem = new InventoryItem();
                        break;
                }

                pack.Add(inventoryItem);
            }
            
        }
    }
}