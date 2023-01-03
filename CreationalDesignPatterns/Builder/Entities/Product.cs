using System.Text;

namespace BuilderPattern.Entities
{
    internal class Product
    {
        private List<object> _parts = new List<object>();

        public void Add(string part)
        {
            this._parts.Add(part);
        }

        public string ListParts()
        {
            StringBuilder sb = new();

            for (int i = 0; i < this._parts.Count; i++)
            {
                sb.Append(this._parts[i] + ", ");
            }

            return "Product parts: " + sb.ToString() + "\n";
        }
    }
}
