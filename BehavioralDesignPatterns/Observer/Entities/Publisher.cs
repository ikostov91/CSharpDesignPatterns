using Observer.Interfaces;

namespace Observer.Entities
{
    internal class Publisher : IPublisher
    {
        private readonly List<ISubscriber> _subscribers;

        public Publisher()
        {
            this._subscribers = new();
        }

        public int State { get; set; }

        public void Attach(ISubscriber subscriber)
        {
            this._subscribers.Add(subscriber);
        }

        public void Detach(ISubscriber subscriber)
        {
            this._subscribers.Remove(subscriber);
        }

        public void DoBusinessLogic()
        {
            this.State = new Random().Next(0, 10);
            Console.WriteLine("Publisher state changed to " + this.State);

            this.Notify();
        }

        public void Notify()
        {
            foreach (var subscriber in this._subscribers)
            {
                subscriber.Update(this);
            }
        }
    }
}
