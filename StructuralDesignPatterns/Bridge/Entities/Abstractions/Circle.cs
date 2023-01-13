using Bridge.Interfaces;

namespace Bridge.Entities.Abstractions
{
    internal class Circle : Shape
    {
        public Circle(IImplementation implementation)
            : base(implementation)
        {
        }

        public override string ShapeMethod()
        {
            return "Extended Abstraction: Circle with " + _implementation.ConcreteImplementationMethod();
        }
    }
}
