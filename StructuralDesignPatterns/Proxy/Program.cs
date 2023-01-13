
using ProxyPattern.Entities;

namespace ProxyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RealSubject realSubject = new();
            Client.ClientCode(realSubject);

            Console.WriteLine();

            Proxy proxy = new(realSubject);
            Client.ClientCode(proxy);
        }
    }
}