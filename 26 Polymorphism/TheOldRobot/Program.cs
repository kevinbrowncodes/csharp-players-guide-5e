using System.Threading.Channels;
using System.Transactions;

namespace TheOldRobot
{
    internal class Program
    {
        /* Make a NorthCommand, SouthCommand, WestCommand, and East Command that move the robot 1 unit in the +Y direction, 1 unit in the -Y direction, 1 unit in the +X direction, respectively. Also, ensure that these commands only work if the robot's IsPowered property is true. */
        /* Make your main method able to collect three commands from the console window. Generate new RobotCommand objects based on the text enetered. After filling the robot's command set with these new RobotCommand objects, use the robot's Run method to execute them. */
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
                RobotCommand newCommand = input switch
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