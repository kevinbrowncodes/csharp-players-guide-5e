﻿namespace ListOfCommands
{
    public class OffCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            robot.IsPowered = false;
        }
    }
}