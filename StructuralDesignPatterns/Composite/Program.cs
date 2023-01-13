using CompositePattern.Entities.Components;
using CompositePattern.Entities;

namespace CompositePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Console", 700);
            Client.ClientCode(product);

            Box boxOne = new();
            Box boxTwo = new();
            boxTwo.Add(new Product("Gamepad", 140));
            boxTwo.Add(new Product("Headset", 100));
            Box boxThree = new();
            boxThree.Add(new Product("Game", 160));
            boxOne.Add(boxTwo);
            boxOne.Add(boxThree);

            Client.ClientCode(boxOne);

            Client.ClientCode2(boxOne, product);
        }
    }
}