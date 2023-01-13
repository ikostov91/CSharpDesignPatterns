namespace Flyweight.Entities
{
    internal class FlyweightFactory
    {
        private Dictionary<string, Flyweight> _flyweights = new();

        public FlyweightFactory(params Car[] cars)
        {
            foreach (var car in cars)
            {
                this._flyweights.Add(GetKey(car), new Flyweight(car));
            }
        }

        public static string GetKey(Car key)
        {
            List<string> elements = new()
            {
                key.Model,
                key.Color,
                key.Company
            };

            if (key.Owner != null && key.Number != null)
            {
                elements.Add(key.Number);
                elements.Add(key.Owner);
            }

            elements.Sort();

            return string.Join("_", elements);
        }

        public Flyweight GetFlyweight(Car sharedState)
        {
            string key = GetKey(sharedState);

            if (!this._flyweights.TryGetValue(key, out Flyweight? flyweight))
            {
                var newFlyweight = new Flyweight(sharedState);
                this._flyweights[key] = newFlyweight;

                return newFlyweight;
            }

            return flyweight;
        }

        public void ListFlyweights()
        {
            foreach (var flyweight in _flyweights)
            {
                Console.WriteLine(flyweight);
            }
        }
    }
}
