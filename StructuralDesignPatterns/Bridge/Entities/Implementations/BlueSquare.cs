using Bridge.Interfaces;

namespace Bridge.Entities.Implementations
{
    internal class BlueSquare : IImplementation
    {
        public string OperationImplementation()
        {
            return "Concrete Implementation: Blue Square";
        }
    }
}
