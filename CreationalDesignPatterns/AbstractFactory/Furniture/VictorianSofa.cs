using AbstractFactory.Interfaces;

namespace AbstractFactory.Products
{
    internal class VictorianSofa : ISofa
    {
        public string SofaFunction()
        {
            return "Victorian Sofa";
        }
    }
}
