using Strategy.Interfaces;

namespace Strategy.Entities
{
    internal class Context
    {
        private IStrategy _strategy;

        public Context() { }

        public Context(IStrategy strategy)
        {
            this._strategy = strategy;  
        }

        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void DoBusinessLogicUsingStrategy()
        {
            Console.WriteLine("Sorting data using the strategy with no knowledge of the concrete implementation");

            var result = this._strategy.DoAlgorithm(new List<string> { "a", "b", "c", "d", "e" });

            string resultStr = string.Empty;
            foreach (var element in result as List<string>)
            {
                resultStr += element + ", ";
            }

            Console.WriteLine(resultStr);
        }
    }
}
