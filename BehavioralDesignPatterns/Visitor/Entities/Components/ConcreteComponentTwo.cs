using Visitor.Interfaces;

namespace Visitor.Entities.Components
{
    internal class ConcreteComponentTwo : IComponent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteComponentTwo(this);
        }

        public string SpecialMethodOfConcreteComponentTwo()
        {
            return "Two";
        }
    }
}
