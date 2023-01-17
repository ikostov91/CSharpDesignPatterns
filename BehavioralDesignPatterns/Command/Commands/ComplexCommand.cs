using Command.Entities;
using Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    internal class ComplexCommand : ICommand
    {
        private readonly Receiver _receiver;

        private readonly string _a;

        private readonly string _b;

        public ComplexCommand(Receiver receiver, string a, string b)
        {
            _receiver = receiver;
            _a = a;
            _b = b;
        }

        public void Execute()
        {
            _receiver.DoSomething(_a);
            _receiver.DoSomethingElse(_b);
        }
    }
}
