namespace CompositePattern.Entities.Components
{
    internal class Product : BaseItem
    {
        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; }
        public decimal Price { get; }

        public override decimal GetPrice()
        {
            return this.Price;
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}
