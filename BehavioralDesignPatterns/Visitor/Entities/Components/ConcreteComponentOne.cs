using Visitor.Interfaces;

namespace Visitor.Entities.Components
{
    internal class ConcreteComponentOne : IComponent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteComponentOne(this);
        }

        public string ExclusiveMethodOfConcreteComponentOne()
        {
            return "One";
        }
    }
}
