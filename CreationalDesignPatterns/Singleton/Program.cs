using SingletonPattern.Entities;

namespace SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread firstProcess = new(() =>
            {
                TestSingletonInstance("firstProcess");
            });
            Thread secondProcess = new(() =>
            {
                TestSingletonInstance("secondProcess");
            });

            firstProcess.Start();
            secondProcess.Start();

            firstProcess.Join();
            secondProcess.Join();
        }

        private static void TestSingletonInstance(string value)
        {
            Singleton singletonInstance = Singleton.GetInstance(value);
            Console.WriteLine(singletonInstance.Value);
        }
    }
}