using Strategy.Interfaces;

namespace Strategy.Entities.Strategies
{
    internal class ConcreteStrategyTwo : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();
            list.Reverse();

            return list;
        }
    }
}
