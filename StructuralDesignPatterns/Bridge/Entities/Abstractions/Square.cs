using Bridge.Interfaces;

namespace Bridge.Entities.Abstractions
{
    internal class Square : Shape
    {
        public Square(IImplementation implementation)
            : base(implementation)
        {
        }

        public override string Operation()
        {
            return "Extended Abstraction: Square with " + _implementation.OperationImplementation();
        }
    }
}
