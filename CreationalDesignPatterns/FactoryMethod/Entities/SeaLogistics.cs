using FactoryMethod.Interfaces;
using FactoryMethod.Transports;

namespace FactoryMethod.Entities
{
    internal class SeaLogistics : Logistics
    {
        public override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}
