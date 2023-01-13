namespace Decorator.Entities.Components
{
    internal class EmailNotifier : Notifier
    {
        public override string Notify()
        {
            return "Notify through Email.";
        }
    }
}
