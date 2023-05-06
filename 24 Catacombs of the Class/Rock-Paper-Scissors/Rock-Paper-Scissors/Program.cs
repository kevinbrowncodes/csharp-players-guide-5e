using System;
using Rock_Paper_Scissors;

Player player1 = new Player();
Player player2 = new Player();

/* Two humans compete against each other */
/* Each player picks Rock, Paper, Scissors */
/* Depending on the player's choice, a winner is determined */
/* The game will keep running until the window is closed 
 * but must remember the historical record of how many times
 * each player won and how many draws there were */
Console.WriteLine("\nPlayer 1 what is your name? \n");
player1.Name = Console.ReadLine();

Console.WriteLine("\nPlayer 2 what is your name? \n");
player2.Name = Console.ReadLine();

while (true)
{
    Console.WriteLine("\nPlayer 1 choose your weapon: ");
    Console.WriteLine("rock");
    Console.WriteLine("paper");
    Console.WriteLine("scissors \n");
    player1.Weapon = Console.ReadLine();

    // player 2
    Console.WriteLine("\nPlayer 2 choose your weapon: "); ;
    Console.WriteLine("rock");
    Console.WriteLine("paper");
    Console.WriteLine("scissors \n");
    player2.Weapon = Console.ReadLine();

    /* The game must display who won the round */
    // determine winner
    string outcome = Game.DetermineOutcome(player1, player2);
    Console.WriteLine($"\nThe outcome is: {outcome}");

    // status
    Console.WriteLine($"\nPlayer 1: {player1.Name}");
    Console.WriteLine($"Wins: {player1.Wins}");
    Console.WriteLine($"\nPlayer 2: {player2.Name}");
    Console.WriteLine($"Wins: {player2.Wins}");
}
