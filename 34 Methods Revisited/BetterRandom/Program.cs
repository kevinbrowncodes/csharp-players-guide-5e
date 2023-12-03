namespace BetterRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int randomDouble;
            string randomSting;
            bool randomFlip;

            Random random = new Random();

            randomDouble = random.NextDoubleExtension();
            Console.WriteLine(randomDouble);

            randomSting = random.NextStringExtension("villager1", "villager2", "village3");
            Console.WriteLine(randomSting);

            randomFlip = random.NextCoinFlip(.8);
            Console.WriteLine(randomFlip);
        }
    }
}