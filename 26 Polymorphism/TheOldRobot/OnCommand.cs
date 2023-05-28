using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOldRobot
{
    /* Make OnCommand and OffCommand classes that inherit from RobotCommand and turn the robot on or off by overriding the Run method. */
    public class OnCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            robot.IsPowered = true;
        }
    }
}
