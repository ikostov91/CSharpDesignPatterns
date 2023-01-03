using FactoryMethod.Interfaces;
using FactoryMethod.Transports;

namespace FactoryMethod.Entities
{
    internal class RoadLogistics : Logistics
    {
        public override ITransport CreateTransport()
        {
            return new Truck();
        }
    }
}
