namespace CompositePattern.Entities.Components
{
    internal abstract class BaseItem
    {
        public BaseItem() { }

        public abstract decimal GetPrice();

        public virtual void Add(BaseItem baseItem)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(BaseItem baseItem)
        {
            throw new NotImplementedException();
        }

        public virtual bool IsComposite()
        {
            return true;
        }
    }
}
