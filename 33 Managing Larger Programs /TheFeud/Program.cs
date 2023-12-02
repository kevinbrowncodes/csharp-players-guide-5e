using IField;
using McDroid;

namespace TheFeud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sheep sheep = new Sheep();
            IField.Pig pigIField = new IField.Pig();
            Cow cow = new Cow();
            McDroid.Pig pigMcDroid = new McDroid.Pig();

            sheep.Hello();
            pigIField.Hello();
            cow.Hello();
            pigMcDroid.Hello();
        }
    }
}