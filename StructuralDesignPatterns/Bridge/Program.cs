using Bridge.Entities.Abstractions;
using Bridge.Entities.Implementations;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape abstraction;

            abstraction = new Shape(new BlueCircle());
            Console.WriteLine(abstraction.Operation());

            abstraction = new Square(new RedSquare());
            Console.WriteLine(abstraction.Operation());
        }
    }
}