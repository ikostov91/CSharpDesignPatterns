using Mediator.Interfaces;

namespace Mediator.Entities.Components
{
    internal class ConcreteUser : User
    {
        public ConcreteUser(IFacebookGroupMediator mediator, string name)
            : base(mediator, name) { }

        public override void Receive(string message)
        {
            Console.WriteLine(this._name + " received message: " + message);
        }

        public override void Send(string message)
        {
            Console.WriteLine(this._name + " sending message: " + message + "\n");
            this._mediator.SendMessage(message, this);
        }
    }
}
