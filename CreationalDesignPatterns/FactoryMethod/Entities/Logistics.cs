using FactoryMethod.Interfaces;

namespace FactoryMethod.Entities
{
    internal abstract class Logistics
    {
        // The FactoryMethod
        public abstract ITransport CreateTransport();

        public string PlanDelivery()
        {
            var transport = this.CreateTransport();

            var result = transport.Deliver();

            return result;
        }
    }
}
