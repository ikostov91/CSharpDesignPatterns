using AbstractFactory.Factories;
using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using ArtDeco furniture factory");
            CreateProducts(new ArtDecoFactory());

            Console.WriteLine();

            Console.WriteLine("Using Victorian furniture factory");
            CreateProducts(new VictorianFactory());
        }

        public static void CreateProducts(IFurnitureFactory factory)
        {
            var sofa = factory.CreateSofa();
            var coffeeTable = factory.CreateCoffeeTable();

            Console.WriteLine(sofa.SofaFunction());
            Console.WriteLine(coffeeTable.CoffeeTableFunction());
            Console.WriteLine(coffeeTable.AnotherCoffeeTableFunction(sofa));
        }
    }
}