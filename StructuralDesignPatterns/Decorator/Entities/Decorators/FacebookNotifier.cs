using Decorator.Entities.Components;

namespace Decorator.Entities.Decorators
{
    internal class FacebookNotifier : Decorator
    {
        public FacebookNotifier(Notifier component)
            : base(component) { }

        public override string Notify()
        {
            return "Notify through Facebook. " + base.Notify();
        }
    }
}
