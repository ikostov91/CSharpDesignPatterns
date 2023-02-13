namespace Memento.Interfaces
{
    internal interface IMemento
    {
        string GetName();

        string GetState();

        DateTime GetDate();
    }
}
