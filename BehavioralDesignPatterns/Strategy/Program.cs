using Strategy.Entities;
using Strategy.Entities.Strategies;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();

            Console.WriteLine("Strategy is set to normal sorting.");
            context.SetStrategy(new ConcreteStrategyOne());
            context.DoBusinessLogicUsingStrategy();

            Console.WriteLine();

            Console.WriteLine("Strategy is set to reverse sorting.");
            context.SetStrategy(new ConcreteStrategyTwo());
            context.DoBusinessLogicUsingStrategy();
        }
    }
}