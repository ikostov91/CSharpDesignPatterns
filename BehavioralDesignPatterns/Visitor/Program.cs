using Visitor.Entities.Components;
using Visitor.Entities.Visitors;
using Visitor.Interfaces;

namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IComponent> components = new List<IComponent>
            {
                new ConcreteComponentOne(),
                new ConcreteComponentTwo()
            };

            Console.WriteLine("Client code works with all visitors via the base Visitor interface.");
            var visitorOne = new ConcreteVisitorOne();
            Client.ClientCode(components, visitorOne);

            Console.WriteLine();

            Console.WriteLine("It allows the same client code to work with different types of visitors:");
            var visitorTwo = new ConcreteVisitorTwo();
            Client.ClientCode(components, visitorTwo);
        }
    }
}