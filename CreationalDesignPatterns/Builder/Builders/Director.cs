using BuilderPattern.Interfaces;

namespace BuilderPattern.Builders
{
    internal class Director
    {
        private IBuilder _builder;

        public Director(IBuilder carBuilder)
        {
            this._builder = carBuilder;
        }

        public void BuildMinimalViableProduct()
        {
            this._builder.BuildPartA();
        }

        public void BuildFullFeaturedProduct()
        {
            this._builder.BuildPartA();
            this._builder.BuildPartC();
            this._builder.BuildPartB();
        }
    }
}
