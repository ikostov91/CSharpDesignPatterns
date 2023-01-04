using Prototype.Entities;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Ivaylo Kostov";
            person.Age = 31;
            person.BirthDate = Convert.ToDateTime("16-11-1991");
            person.IdInfo = new IdInfo(1);

            Person personShallowCopy = (Person)person.ShallowCopy();
            Person personDeepCopy = (Person)person.DeepCopy();

            Console.WriteLine(person);
            Console.WriteLine(personShallowCopy);
            Console.WriteLine(personDeepCopy);
            Console.WriteLine();

            person.Name = "Atanaska Kostova";
            person.Age = 28;
            person.BirthDate = Convert.ToDateTime("17-09-1994");
            person.IdInfo.IdNumber = 2;

            Console.WriteLine(person);
            Console.WriteLine(personShallowCopy);
            Console.WriteLine(personDeepCopy);
        }
    }
}