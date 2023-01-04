using AbstractFactory.Interfaces;
using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    internal class ArtDecoFactory : IFurnitureFactory
    {
        public ISofa CreateSofa()
        {
            return new ArtDecoSofa();
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new ArtDecoCoffeeTable();
        }
    }
}
