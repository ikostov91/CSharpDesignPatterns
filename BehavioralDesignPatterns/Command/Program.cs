using Command.Commands;
using Command.Entities;

namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new(new SimpleCommand("Execute simple action"));
            invoker.ExecuteCommand();

            Receiver receiver = new();
            invoker = new(new ComplexCommand(receiver, "Send email", "Save report"));
            invoker.ExecuteCommand();
        }
    }
}