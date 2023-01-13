using Bridge.Interfaces;

namespace Bridge.Entities.Implementations
{
    internal class RedCircle : IImplementation
    {
        public string ConcreteImplementationMethod()
        {
            return "Concrete Implementation: Red Circle";
        }
    }
}
