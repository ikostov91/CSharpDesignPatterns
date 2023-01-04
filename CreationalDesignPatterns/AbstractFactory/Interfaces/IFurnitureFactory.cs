namespace AbstractFactory.Interfaces
{
    internal interface IFurnitureFactory
    {
        ISofa CreateSofa();

        ICoffeeTable CreateCoffeeTable();
    }
}
