using Strategy.Interfaces;

namespace Strategy.Entities.Strategies
{
    internal class ConcreteStrategyOne : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();

            return list;
        }
    }
}
