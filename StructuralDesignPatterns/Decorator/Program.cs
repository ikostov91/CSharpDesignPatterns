using Decorator.Entities.Components;
using Decorator.Entities;
using Decorator.Entities.Decorators;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emailNotifier = new EmailNotifier();
            Console.WriteLine("EmailNotifier:");
            Client.ClientCode(emailNotifier);

            Console.WriteLine();

            FacebookNotifier facebookNotifierDecorator = new FacebookNotifier(emailNotifier);
            SlackNotifier slackNotifierDecorator = new SlackNotifier(facebookNotifierDecorator);
            Console.WriteLine("Wrapped EmailNotifier with Facebook and Slack.");
            Client.ClientCode(slackNotifierDecorator);
        }
    }
}