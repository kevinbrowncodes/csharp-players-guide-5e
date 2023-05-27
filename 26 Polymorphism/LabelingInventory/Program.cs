namespace LabelingInventory
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            string itemInput;
            InventoryItem inventoryItem;

            Pack pack = new Pack(10, 20, 30);

            Arrow arrow2 = new Arrow();
            Console.WriteLine(arrow2.ToString());

            while (!pack.Full)
            {
                Console.WriteLine("\nBag status");
                Console.WriteLine($"Max Count: {pack.MaxCount} Current Count: {pack.CurrentCount}");
                Console.WriteLine($"Max Weight: {pack.MaxWeight} Current Weight: {pack.CurrentWeight}");
                Console.WriteLine($"Max Volume: {pack.MaxVolume} Current Volume: {pack.CurrentVolume}");

                Console.WriteLine("\nWhat do you want to pack?");
                Console.WriteLine("SELECTION\tITEM\tWEIGHT\tVolume");
                Console.WriteLine("1\t\tarrow\t0.1\t0.05");
                Console.WriteLine("2\t\tbow\t1\t4");
                Console.WriteLine("3\t\trope\t1\t1.5");
                Console.WriteLine("4\t\twater\t2\t3");
                Console.WriteLine("5\t\tfood\t1\t0.5");
                Console.WriteLine("6\t\tsword\t5\t3");
                itemInput = Console.ReadLine();

                /* Override the existing ToString method (from the obejct base class) on all of your inventory item subclasses to give them a name. For example, new Rope().ToString() should return "Rope". */
                switch (itemInput)
                {
                    case "1":
                        inventoryItem = new Arrow();
                        Console.WriteLine($"\nYou selected " + inventoryItem.ToString());
                        break;
                    case "2":
                        inventoryItem = new Bow();
                        Console.WriteLine($"\nYou selected " + inventoryItem.ToString());
                        break;
                    case "3":
                        inventoryItem = new Rope();
                        Console.WriteLine($"\nYou selected " + inventoryItem.ToString());
                        break;
                    case "4":
                        inventoryItem = new Water();
                        Console.WriteLine($"\nYou selected " + inventoryItem.ToString());
                        break;
                    case "5":
                        inventoryItem = new Food();
                        Console.WriteLine($"\nYou selected " + inventoryItem.ToString());
                        break;
                    case "6":
                        inventoryItem = new Sword();
                        Console.WriteLine($"\nYou selected " + inventoryItem.ToString());
                        break;
                    default:
                        inventoryItem = new InventoryItem();
                        break;
                }

                pack.Add(inventoryItem);

                /* Before the user chooses the next item to add, display the pack's current contents via its new ToString method. */
                Console.WriteLine(pack.ToString());
            }
            
        }
    }
}