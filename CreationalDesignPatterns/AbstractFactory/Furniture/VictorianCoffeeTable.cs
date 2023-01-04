using AbstractFactory.Interfaces;

namespace AbstractFactory.Products
{
    internal class VictorianCoffeeTable : ICoffeeTable
    {
        public string CoffeeTableFunction()
        {
            return "Victorian Coffee table";
        }

        public string AnotherCoffeeTableFunction(ISofa collaborator)
        {
            var result = collaborator.SofaFunction();

            return $"Victorian Coffee table collaborating with {result}";
        }
    }
}
