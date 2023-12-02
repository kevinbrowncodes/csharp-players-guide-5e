namespace SaferNumberCrunching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            
            while (true)
            {
                Console.WriteLine("\nPlease enter a int value:");
                input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    Console.WriteLine($"You entered: {number}");
                    break;
                }
                else
                {
                    Console.WriteLine($"Invalid number!");
                }
            }

            while (true)
            {
                Console.WriteLine("\nPlease enter a double value:");
                input = Console.ReadLine();

                if (double.TryParse(input, out double number))
                {
                    Console.WriteLine($"You entered: {number}");
                    break;
                }
                else
                {
                    Console.WriteLine($"Invalid number!");
                }
            }

            while (true)
            {
                Console.WriteLine("\nPlease enter a boolean value:");
                input = Console.ReadLine();

                if (bool.TryParse(input, out bool boolean))
                {
                    Console.WriteLine($"You entered: {boolean}");
                    break;
                }
                else
                {
                    Console.WriteLine($"Invalid boolean!");
                }
            }

        }
    }
}