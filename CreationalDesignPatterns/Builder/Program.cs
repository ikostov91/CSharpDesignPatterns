using BuilderPattern.Builders;

namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new Builder();
            var director = new Director(builder);

            Console.WriteLine("Standard basic product:");
            director.BuildMinimalViableProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Standard full featured product:");
            director.BuildFullFeaturedProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Custom product:");
            builder.BuildPartA();
            builder.BuildPartB();
            Console.Write(builder.GetProduct().ListParts());
        }
    }
}