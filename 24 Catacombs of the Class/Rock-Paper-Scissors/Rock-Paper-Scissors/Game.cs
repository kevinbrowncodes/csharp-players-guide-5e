using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    public static class Game
    {
        // methods
        public static string DetermineOutcome(Player player1, Player player2)
        {
            string player1Weapon = player1.Weapon;
            string player2Weapon = player2.Weapon;
            string outcome = "";

            if (player1Weapon == "rock")
            {
                if (player2Weapon == "rock")
                {
                    outcome = "tie";
                }
                else if (player2Weapon == "paper")
                {
                    player1.Wins += 1;
                    outcome = "player 1 wins!";
                    
                }
                else if (player2Weapon == "scissors")
                {
                    player2.Wins += 1;
                    outcome = "player 2 wins!";
                }
                else
                {
                    outcome = "error";
                }
            }
            else if (player1Weapon == "paper")
            {
                if (player2Weapon == "rock")
                {
                    player1.Wins += 1;
                    outcome = "player 1 wins!";
                }
                else if (player2Weapon == "paper")
                {
                    outcome = "draw";
                }
                else if (player2Weapon == "scissors")
                {

                    player2.Wins += 1;
                    outcome = "player 2 wins!";
                }
                else
                {
                    outcome = "error";
                }
            }
            else if (player1Weapon == "scissors")
            {
                if (player2Weapon == "rock")
                {
                    player2.Wins += 1;
                    outcome = "player 2 wins!";
                }
                else if (player2Weapon == "paper")
                {
                    player1.Wins += 1;
                    outcome = "player 1 wins";
                }
                else if (player2Weapon == "scissors")
                {
                    outcome = "draw";
                }
                else
                {
                    outcome = "error";
                }
            }

            return outcome;
        }
    }
}
