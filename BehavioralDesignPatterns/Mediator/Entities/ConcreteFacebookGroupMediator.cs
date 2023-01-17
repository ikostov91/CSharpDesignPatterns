using Mediator.Entities.Components;
using Mediator.Interfaces;

namespace Mediator.Entities
{
    internal class ConcreteFacebookGroupMediator : IFacebookGroupMediator
    {
        private readonly List<User> _users;

        public ConcreteFacebookGroupMediator()
        {
            this._users = new();
        }

        public void RegisterUser(User newUser)
        {
            this._users.Add(newUser);
        }

        public void SendMessage(string message, User user)
        {
            foreach (User u in this._users)
            {
                if (u != user)
                {
                    u.Receive(message);
                }
            }
        }
    }
}
