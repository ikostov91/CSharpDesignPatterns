using Decorator.Entities.Components;

namespace Decorator.Entities
{
    internal class Client
    {
        public static void ClientCode(Notifier component)
        {
            Console.WriteLine(component.Notify());
        }
    }
}
