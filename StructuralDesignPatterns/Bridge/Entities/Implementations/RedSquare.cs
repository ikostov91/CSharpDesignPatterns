using Bridge.Interfaces;

namespace Bridge.Entities.Implementations
{
    internal class RedSquare : IImplementation
    {
        public string OperationImplementation()
        {
            return "Concrete Implementation: Red Square";
        }
    }
}
