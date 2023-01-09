using Bridge.Interfaces;

namespace Bridge.Entities.Abstractions
{
    internal class Shape
    {
        protected IImplementation _implementation;

        public Shape(IImplementation implementation)
        {
            _implementation = implementation;
        }

        public virtual string Operation()
        {
            return "Abstract: Shape with " + _implementation.OperationImplementation();
        }
    }
}
