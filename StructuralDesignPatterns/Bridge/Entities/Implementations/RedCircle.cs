using Bridge.Interfaces;

namespace Bridge.Entities.Implementations
{
    internal class RedCircle : IImplementation
    {
        public string OperationImplementation()
        {
            return "Concrete Implementation: Red Circle";
        }
    }
}
