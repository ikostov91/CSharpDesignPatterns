using Visitor.Entities.Components;
using Visitor.Interfaces;

namespace Visitor.Entities.Visitors
{
    internal class ConcreteVisitorOne : IVisitor
    {
        public void VisitConcreteComponentOne(ConcreteComponentOne element)
        {
            Console.WriteLine("ConcreteVisitorOne: " + element.ExclusiveMethodOfConcreteComponentOne());
        }

        public void VisitConcreteComponentTwo(ConcreteComponentTwo element)
        {
            Console.WriteLine("ConcreteVisitorOne: " + element.SpecialMethodOfConcreteComponentTwo());
        }
    }
}
