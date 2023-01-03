using FactoryMethod.Interfaces;

namespace FactoryMethod.Transports
{
    internal class Truck : ITransport
    {
        public string Deliver()
        {
            return "Deliver cargo by land using Truck.";
        }
    }
}
