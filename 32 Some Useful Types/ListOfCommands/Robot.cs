namespace ListOfCommands
{
    public class Robot
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsPowered { get; set; }
        //public IRobotCommand?[] Commands { get; } = new IRobotCommand?[3];
        public List<IRobotCommand?> Commands { get; } = new List<IRobotCommand?>();

        public void Run()
        {
            foreach (IRobotCommand? command in Commands)
            {
                command?.Run(this);
                Console.WriteLine($"[{X} {Y} {IsPowered}]");
            }
        }

    }
}