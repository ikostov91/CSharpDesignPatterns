using Flyweight.Entities;

namespace Flyweight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factory = new FlyweightFactory(
                new Car { Company = "Chevrolet", Model = "Camaro2018", Color = "pink" },
                new Car { Company = "Mercedes Benz", Model = "C300", Color = "black" },
                new Car { Company = "Mercedes Benz", Model = "C500", Color = "red" },
                new Car { Company = "BMW", Model = "M5", Color = "red" },
                new Car { Company = "BMW", Model = "X6", Color = "white" }
            );
            factory.ListFlyweights();

            AddCarToDatabase(factory, new Car
            {
                Number = "CL234IR",
                Owner = "James Doe",
                Company = "BMW",
                Model = "M5",
                Color = "red"
            });

            AddCarToDatabase(factory, new Car
            {
                Number = "CL234IR",
                Owner = "James Doe",
                Company = "BMW",
                Model = "X1",
                Color = "red"
            });

            factory.ListFlyweights();
        }

        public static void AddCarToDatabase(FlyweightFactory factory, Car uniqueState)
        {
            var flyweight = factory.GetFlyweight(new Car
            {
                Color = uniqueState.Color,
                Model = uniqueState.Model,
                Company = uniqueState.Company
            });

            flyweight.OperationUsingUniqueState(uniqueState);
        }
    }
}