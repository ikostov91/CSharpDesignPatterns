using Mediator.Entities.Components;

namespace Mediator.Interfaces
{
    internal interface IFacebookGroupMediator
    {
        void SendMessage(string msg, User user);
        void RegisterUser(User user);
    }
}
