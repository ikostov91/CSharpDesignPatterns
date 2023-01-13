using ProxyPattern.Interfaces;

namespace ProxyPattern.Entities
{
    internal class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject: Handling Request.");
        }
    }
}
