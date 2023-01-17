using Observer.Entities;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var publisher = new Publisher();
            var subscriberOne = new ConcreteSubscriberOne();
            publisher.Attach(subscriberOne);

            var subscriberTwo = new ConcreteSubscriberTwo();
            publisher.Attach(subscriberTwo);

            publisher.DoBusinessLogic();
            publisher.DoBusinessLogic();

            publisher.Detach(subscriberTwo);

            publisher.DoBusinessLogic();
        }
    }
}