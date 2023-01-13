using Bridge.Interfaces;

namespace Bridge.Entities.Implementations
{
    internal class BlueSquare : IImplementation
    {
        public string ConcreteImplementationMethod()
        {
            return "Concrete Implementation: Blue Square";
        }
    }
}
