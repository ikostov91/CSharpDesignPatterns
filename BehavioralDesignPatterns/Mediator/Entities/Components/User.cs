using Mediator.Interfaces;

namespace Mediator.Entities.Components
{
    internal abstract class User
    {
        protected string _name;
        protected IFacebookGroupMediator _mediator;

        public User(IFacebookGroupMediator mediator, string name)
        {
            this._mediator = mediator;
            this._name = name;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}
