using Decorator.Entities.Components;

namespace Decorator.Entities.Decorators
{
    internal abstract class Decorator : Notifier
    {
        protected Notifier _component;

        public Decorator(Notifier component)
        {
            this._component = component;
        }

        public void SetComponent(Notifier component)
        {
            this._component = component;
        }

        public override string Notify()
        {
            if (this._component != null)
            {
                return this._component.Notify();
            }

            return string.Empty;
        }
    }
}
