using Observer.Interfaces;

namespace Observer.Entities
{
    internal class ConcreteSubscriberOne : ISubscriber
    {
        public void Update(IPublisher? publisher)
        {
            if ((publisher as Publisher)?.State < 3)
            {
                Console.WriteLine("ConcreteObserverA: Reacted to the event.");
            }
        }
    }
}
