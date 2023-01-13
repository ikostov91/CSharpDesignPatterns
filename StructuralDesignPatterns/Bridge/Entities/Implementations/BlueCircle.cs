using Bridge.Interfaces;

namespace Bridge.Entities.Implementations
{
    internal class BlueCircle : IImplementation
    {
        public string ConcreteImplementationMethod()
        {
            return "Concrete Implementation: Blue Circle";
        }
    }
}
