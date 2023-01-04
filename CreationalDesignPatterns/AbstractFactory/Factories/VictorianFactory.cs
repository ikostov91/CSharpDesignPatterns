using AbstractFactory.Interfaces;
using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    internal class VictorianFactory : IFurnitureFactory
    {
        public ISofa CreateSofa()
        {
            return new VictorianSofa();
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new VictorianCoffeeTable();
        }
    }
}
