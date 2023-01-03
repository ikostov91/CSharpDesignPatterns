namespace SingletonPattern.Entities
{
    internal class Singleton
    {
        private static Singleton? _instance;
        private static readonly object _lock = new();

        private Singleton() { }

        public static Singleton GetInstance(string value)
        {
            if (_instance is null)
            {
                lock (_lock)
                {
                    if (_instance is null)
                    {
                        _instance = new Singleton
                        {
                            Value = value
                        };
                    }
                }
            }

            return _instance;
        }

        public string? Value { get; private set; }
    }
}
