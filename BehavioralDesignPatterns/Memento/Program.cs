using Memento.Entities;

namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextEditor textEditor = new("");
            Caretaker caretaker = new(textEditor);

            textEditor.Edit();
            caretaker.Backup();

            textEditor.Edit();
            caretaker.Backup();

            textEditor.Edit();
            caretaker.Backup();

            Console.WriteLine();
            caretaker.ShowHistory();

            caretaker.Undo();
            caretaker.Undo();

            Console.WriteLine();
        }
    }
}