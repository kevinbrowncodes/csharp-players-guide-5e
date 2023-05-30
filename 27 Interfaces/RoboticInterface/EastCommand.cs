using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboticInterface
{
    public class EastCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            if(robot.IsPowered) { robot.X++; }
        }
    }
}
