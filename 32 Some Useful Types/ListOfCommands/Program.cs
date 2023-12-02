namespace ListOfCommands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();

            while(true) 
            {
                Console.WriteLine("\nEnter a command: ");
                Console.WriteLine("on");
                Console.WriteLine("off");
                Console.WriteLine("north");
                Console.WriteLine("south");
                Console.WriteLine("east");
                Console.WriteLine("west");
                Console.WriteLine("stop");
                Console.WriteLine();

                string? input = Console.ReadLine();

                if (input == "stop") break;

                IRobotCommand newCommand = input switch
                {
                    "on" => new OnCommand(),
                    "off" => new OffCommand(),
                    "north" => new NorthCommand(),
                    "south" => new SouthCommand(),
                    "east" => new EastCommand(),
                    "west" => new WestCommand()
                };

                //robot.Commands[i] = newCommand;
                robot.Commands.Add(newCommand);
            }

            robot.Run();
        }
    }
}