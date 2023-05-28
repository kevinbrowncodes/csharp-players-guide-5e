using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOldRobot
{
    /* Copy the code above into a new project */
    public class Robot
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsPowered { get; set; }
        public RobotCommand?[] Commands { get; } = new RobotCommand?[3];
        
        public void Run()
        {
            foreach (RobotCommand? command in Commands) 
            { 
                command?.Run(this);
                Console.WriteLine($"[{X} {Y} {IsPowered}]");
            }
        }

    }
}
