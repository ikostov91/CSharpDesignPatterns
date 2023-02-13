using Visitor.Entities.Components;
using Visitor.Interfaces;

namespace Visitor.Entities.Visitors
{
    internal class ConcreteVisitorTwo : IVisitor
    {
        public void VisitConcreteComponentOne(ConcreteComponentOne element)
        {
            Console.WriteLine(element.ExclusiveMethodOfConcreteComponentOne() + " + ConcreteVisitorTwo");
        }

        public void VisitConcreteComponentTwo(ConcreteComponentTwo element)
        {
            Console.WriteLine(element.SpecialMethodOfConcreteComponentTwo() + " + ConcreteVisitorTwo");
        }
    }
}
