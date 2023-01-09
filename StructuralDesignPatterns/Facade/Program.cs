using FacadePattern.Entities;

namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SubsystemOne subsystem1 = new SubsystemOne();
            SubsystemTwo subsystem2 = new SubsystemTwo();
            Facade facade = new(subsystem1, subsystem2);
            
            Console.WriteLine(facade.Operation());
        }
    }
}