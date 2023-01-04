namespace AbstractFactory.Interfaces
{
    internal interface ICoffeeTable
    {
        string CoffeeTableFunction();

        string AnotherCoffeeTableFunction(ISofa collaborator);
    }
}
