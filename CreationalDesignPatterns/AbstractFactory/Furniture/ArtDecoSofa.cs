using AbstractFactory.Interfaces;

namespace AbstractFactory.Products
{
    internal class ArtDecoSofa : ISofa
    {
        public string SofaFunction()
        {
            return "Art Deco Sofa";
        }
    }
}
