using FactoryMethod.Entities;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client code using RoadLogistics.");
            Logistics roadLogistics = new RoadLogistics();
            Console.WriteLine(roadLogistics.PlanDelivery());

            Console.WriteLine();

            Console.WriteLine("Client code using SeaLogistics.");
            Logistics seaLogistics = new SeaLogistics();
            Console.WriteLine(seaLogistics.PlanDelivery());
        }
    }
}