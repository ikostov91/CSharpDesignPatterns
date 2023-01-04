using AbstractFactory.Interfaces;

namespace AbstractFactory.Products
{
    internal class ArtDecoCoffeeTable : ICoffeeTable
    {
        public string CoffeeTableFunction()
        {
            return "Art Deco Coffee table";
        }

        public string AnotherCoffeeTableFunction(ISofa collaborator)
        {
            var result = collaborator.SofaFunction();

            return $"Art Deco Coffee table collaborating with {result}";
        }
    }
}
