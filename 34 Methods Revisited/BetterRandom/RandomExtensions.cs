using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterRandom
{
    public static class RandomExtensions
    {
        public static int NextDoubleExtension(this Random random)
        {
            int value;

            value = (int)(random.NextDouble() * 10);


            return value;
        }

        public static string NextStringExtension(this Random random, params string[] strings) 
        {
            string value;
            int stringLen = strings.Length;
            int randomChoice;

            randomChoice = random.Next(stringLen);

            value = strings[randomChoice];

            return value;
        }

        public static bool NextCoinFlip(this Random random, double chance = .5)
        {
            // stimulate chance
            double randomValue = random.NextDouble();
            bool eventOccured = randomValue < chance;

            if (eventOccured) return true;
            else return false;
        }
    }
}
