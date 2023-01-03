using FactoryMethod.Interfaces;

namespace FactoryMethod.Transports
{
    internal class Ship : ITransport
    {
        public string Deliver()
        {
            return "Deliver cargo by sea using Ship.";
        }
    }
}
