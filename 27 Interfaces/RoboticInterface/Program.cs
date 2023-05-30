namespace RoboticInterface
{
    /* Ensure your program still compiles and run */
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();

            for (int i = 0; i <= robot.Commands.Length - 1; i++)
            {
                Console.WriteLine("\nEnter a command: ");
                Console.WriteLine("on");
                Console.WriteLine("off");
                Console.WriteLine("north");
                Console.WriteLine("south");
                Console.WriteLine("east");
                Console.WriteLine("west");
                Console.WriteLine();

                string? input = Console.ReadLine();
                IRobotCommand newCommand = input switch
                {
                    "on" => new OnCommand(),
                    "off" => new OffCommand(),
                    "north" => new NorthCommand(),
                    "south" => new SouthCommand(),
                    "east" => new EastCommand(),
                    "west" => new WestCommand()
                };

                robot.Commands[i] = newCommand;
            }

            robot.Run();
        }
    }
}

/* Question: Do you feel this is an improvement over using an abstract base
 * class? Why or why not? */
// The abstract class is a type of class used in polymorhism that allows
// objects of different types to be treated as objects from a
// common base class (RobotCommand). 
// The interface class is a type used to define members without 
// implementation that a derived class is then expected to
// implement.
// In this particular case it is an improvement since in this case 
// using an abstract base class it is usually an expectation that members
// would need to inherit members from the class. Since in our
// project our commands do not need to inherit any members from the
// the abstract class, using an interface becomes the more
// preferable approach. 