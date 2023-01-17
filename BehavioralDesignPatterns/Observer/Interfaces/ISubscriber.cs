namespace Observer.Interfaces
{
    internal interface ISubscriber
    {
        void Update(IPublisher publisher);
    }
}
