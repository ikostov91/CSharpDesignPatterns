using Memento.Interfaces;

namespace Memento.Entities
{
    internal class TextEditor
    {
        private string _state;

        public TextEditor(string state)
        {
            this._state = state;
        }

        public void Edit()
        {
            Console.Write("Edit text:");
            this._state = Console.ReadLine();
            Console.WriteLine($"Text state changed to: {this._state}");
        }

        public IMemento Save()
        {
            return new ConcreteMemento(this._state);
        }

        public void Restore(IMemento memento)
        {
            if (memento is not ConcreteMemento)
            {
                throw new Exception("Unknown memento class " + memento.ToString());
            }

            this._state = memento.GetState();
            Console.WriteLine($"Text state changed to: {this._state}");
        }
    }
}
