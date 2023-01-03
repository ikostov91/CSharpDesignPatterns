using BuilderPattern.Entities;
using BuilderPattern.Interfaces;

namespace BuilderPattern.Builders
{
    internal class Builder : IBuilder
    {
        private Product _product = new();

        public Builder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._product = new Product();
        }

        public void BuildPartA()
        {
            this._product.Add("PartOne");
        }

        public void BuildPartB()
        {
            this._product.Add("PartTwo");
        }

        public void BuildPartC()
        {
            this._product.Add("PartThree");
        }

        public Product GetProduct()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }
    }
}
