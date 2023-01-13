using AdapterPattern.Interfaces;

namespace AdapterPattern.Entities
{
    internal class XmlToJsonAdapter : ITarget
    {
        private readonly JsonCompatibleClass _adaptee;

        public XmlToJsonAdapter(JsonCompatibleClass adaptee)
        {
            this._adaptee = adaptee;
        }

        public string Request(string xml)
        {
            string convertedToJson = "{ Input: {} }";
            return $"Convert XML to JSON and pass to adaptee: '{this._adaptee.JsonInputMethod(convertedToJson)}'.";
        }
    }
}
