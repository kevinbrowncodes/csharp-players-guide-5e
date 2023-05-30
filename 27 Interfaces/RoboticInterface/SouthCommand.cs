using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboticInterface
{
    public class SouthCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            if(robot.IsPowered) { robot.Y--; }
        }
    }
}
