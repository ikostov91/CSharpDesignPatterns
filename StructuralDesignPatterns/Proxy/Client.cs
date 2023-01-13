using ProxyPattern.Interfaces;

namespace ProxyPattern
{
    internal class Client
    {
        public static void ClientCode(ISubject subject)
        {
            subject.Request();
        }
    }
}
