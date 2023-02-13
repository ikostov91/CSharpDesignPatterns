using Visitor.Entities.Components;

namespace Visitor.Interfaces
{
    internal interface IVisitor
    {
        void VisitConcreteComponentOne(ConcreteComponentOne element);

        void VisitConcreteComponentTwo(ConcreteComponentTwo element);
    }
}
