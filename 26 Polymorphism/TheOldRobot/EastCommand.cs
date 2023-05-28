using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOldRobot
{
    public class EastCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            if(robot.IsPowered) { robot.X++; }
        }
    }
}
