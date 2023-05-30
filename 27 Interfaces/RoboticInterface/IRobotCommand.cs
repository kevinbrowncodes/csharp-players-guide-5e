using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Make all your commands implement this new interface instead of extending
* the RobotCommand class that no longer exists. You will also want to remove
* the override keywords in these classes */
namespace RoboticInterface
{
    /* Change your abstract RobotCommand class into an IRobotCommand interface */
    public interface IRobotCommand
    {
        void Run(Robot robot);
    }
}
