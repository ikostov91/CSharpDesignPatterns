using Bridge.Interfaces;

namespace Bridge.Entities.Implementations
{
    internal class RedSquare : IImplementation
    {
        public string ConcreteImplementationMethod()
        {
            return "Concrete Implementation: Red Square";
        }
    }
}
