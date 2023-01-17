namespace Observer.Interfaces
{
    internal interface IPublisher
    {
        void Attach(ISubscriber observer);
        void Detach(ISubscriber observer);
        void Notify();
    }
}
