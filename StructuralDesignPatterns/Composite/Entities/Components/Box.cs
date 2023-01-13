namespace CompositePattern.Entities.Components
{
    internal class Box : BaseItem
    {
        protected List<BaseItem> _items = new();

        public override void Add(BaseItem item)
        {
            _items.Add(item);
        }

        public override void Remove(BaseItem item)
        {
            _items.Remove(item);
        }

        public override decimal GetPrice()
        {
            decimal priceSum = 0m;

            foreach (BaseItem item in _items)
            {
                priceSum += item.GetPrice();
            }

            return priceSum;
        }
    }
}
