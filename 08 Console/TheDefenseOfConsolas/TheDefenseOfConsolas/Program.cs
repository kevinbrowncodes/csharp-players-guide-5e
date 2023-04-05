int numRow;
int numCol;

/* Change the window title to be "Defense of Consolas" */
#region
Console.Title = "Defense of Consolas";
#endregion

/* Display the deployement instructions in a different colot of your choosing */
#region
Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.DarkBlue;
#endregion

/*  Ask the user for the target row and column */
# region
Console.Write("Target Row? ");

numRow = Convert.ToInt32(Console.ReadLine());

Console.Write("Target Column? ");
numCol = Convert.ToInt32(Console.ReadLine());
# endregion

/* Compute the neighboring rows and columns of where to deploy the squad */
#region 
int numRowDeploy1, numColDeploy1;
int numRowDeploy2, numColDeploy2;
int numRowDeploy3, numColDeploy3;
int numRowDeploy4, numColDeploy4;


numRowDeploy1 = numRow;
numColDeploy1 = numCol - 1;

numRowDeploy2 = numRow - 1;
numColDeploy2 = numCol;

numRowDeploy3 = numRow;
numColDeploy3 = numCol + 1;

numRowDeploy4 = numRow + 1;
numColDeploy4 = numCol;

Console.WriteLine("Deploy to: ");
Console.WriteLine($"({numRowDeploy1}, {numColDeploy1})");
Console.WriteLine($"({numRowDeploy2}, {numColDeploy2})");
Console.WriteLine($"({numRowDeploy3}, {numColDeploy3})");
Console.WriteLine($"({numRowDeploy4}, {numColDeploy4})");
#endregion

/* Play a sound with Console.Beep when the results have been computed and displayed */
#region
Console.Beep();
#endregion