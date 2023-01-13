using Decorator.Entities.Components;

namespace Decorator.Entities.Decorators
{
    internal class SlackNotifier : Decorator
    {
        public SlackNotifier(Notifier component)
            : base(component) { }

        public override string Notify()
        {
            return "Notify through Slack. " + base.Notify();
        }
    }
}
