using Observer.Interfaces;

namespace Observer.Entities
{
    internal class ConcreteSubscriberTwo : ISubscriber
    {
        public void Update(IPublisher? publisher)
        {
            if ((publisher as Publisher)?.State == 0 || (publisher as Publisher)?.State >= 2)
            {
                Console.WriteLine("ConcreteObserverB: Reacted to the event.");
            }
        }
    }
}
