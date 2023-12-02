namespace ListOfCommands
{
    public class SouthCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            if (robot.IsPowered) { robot.Y--; }
        }
    }
}