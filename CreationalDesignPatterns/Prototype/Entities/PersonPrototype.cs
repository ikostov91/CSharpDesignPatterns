namespace Prototype.Entities
{
    internal abstract class PersonPrototype
    {
        public abstract PersonPrototype ShallowCopy();

        public abstract PersonPrototype DeepCopy();
    }
}
