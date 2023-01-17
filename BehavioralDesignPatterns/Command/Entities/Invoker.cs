using Command.Interfaces;

namespace Command.Entities
{
    internal class Invoker
    {
        private readonly ICommand _command;

        public Invoker(ICommand command)
        {
            this._command = command;
        }

        public void ExecuteCommand()
        {
            this._command.Execute();
        }
    }
}
