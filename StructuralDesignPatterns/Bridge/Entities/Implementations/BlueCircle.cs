using Bridge.Interfaces;

namespace Bridge.Entities.Implementations
{
    internal class BlueCircle : IImplementation
    {
        public string OperationImplementation()
        {
            return "Concrete Implementation: Blue Circle";
        }
    }
}
