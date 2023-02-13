using Memento.Interfaces;

namespace Memento.Entities
{
    internal class Caretaker
    {
        private readonly List<IMemento> _mementos = new();
        private readonly TextEditor _textEditor;

        public Caretaker(TextEditor originator)
        {
            this._textEditor = originator;
        }

        public void Backup()
        {
            Console.WriteLine("Caretaker: Saving Text editor's state...");
            this._mementos.Add(this._textEditor.Save());
        }

        public void Undo()
        {
            if (this._mementos.Count == 0)
            {
                return;
            }

            var memento = this._mementos.Last();
            this._mementos.Remove(memento);

            Console.WriteLine("Caretaker: Restoring text editor state to: " + memento.GetName());

            try
            {
                this._textEditor.Restore(memento);
            }
            catch (Exception)
            {
                this.Undo();
            }
        }

        public void ShowHistory()
        {
            Console.WriteLine("Caretaker: Here's the list of mementos:");

            foreach (var memento in this._mementos)
            {
                Console.WriteLine(memento.GetName());
            }
        }
    }
}
