using Mediator.Entities;
using Mediator.Entities.Components;

namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteFacebookGroupMediator facebookMediator = new ConcreteFacebookGroupMediator();

            User james = new ConcreteUser(facebookMediator, "James");
            User steve = new ConcreteUser(facebookMediator, "Steve");
            User peter = new ConcreteUser(facebookMediator, "Peter");

            facebookMediator.RegisterUser(james);
            facebookMediator.RegisterUser(steve);
            facebookMediator.RegisterUser(peter);

            james.Send("Just did the Mediator example!");
            Console.WriteLine();
            steve.Send("What is Mediator? Please explain ");

            Console.Read();
        }
    }
}