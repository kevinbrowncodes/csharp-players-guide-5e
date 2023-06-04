namespace WarPreparations
{
    internal class Program
    {       
        /* In your main program, create a basic Sword instance made out of iron and with no gemstone. Then create two variations on the basic sword using with expressions. */  
        static void Main(string[] args)
        {
            // beginner sword
            Sword begginerSword = new Sword(MaterialType.Iron, GemType.None, 2, 1);

            // intermediate sword
            Sword intermeidateSword = begginerSword with { Material = MaterialType.Steel, Gemstone = GemType.Diamond};

            // advanced sword 
            Sword advancedSword = begginerSword with { Material = MaterialType.Binarium, Gemstone = GemType.Bitstone };

            /* Display all three sword instances with code like Console.WriteLine(original); */
            Console.WriteLine(begginerSword);
            Console.WriteLine(intermeidateSword);
            Console.WriteLine(advancedSword);
        }
    }
}