namespace ListOfCommands
{
    public class NorthCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            if (robot.IsPowered) { robot.Y++; }
        }
    }
}