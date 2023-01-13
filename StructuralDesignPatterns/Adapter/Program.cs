using AdapterPattern.Entities;
using AdapterPattern.Interfaces;

namespace AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JsonCompatibleClass adaptee = new();
            ITarget target = new XmlToJsonAdapter(adaptee);

            Console.WriteLine("JsonCompatibleClass is incompatible with the client code.");
            Console.WriteLine("But with the XmlToJsonAdapter, the client can call it's method.");

            string xmlInput = "<xml>Input</xml>";
            Console.WriteLine(xmlInput);
            Console.WriteLine(target.Request(xmlInput));
        }
    }
}