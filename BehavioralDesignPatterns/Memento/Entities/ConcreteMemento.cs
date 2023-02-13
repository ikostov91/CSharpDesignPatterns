using Memento.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Entities
{
    internal class ConcreteMemento : IMemento
    {
        private string _state;
        private DateTime _date;

        public ConcreteMemento(string state)
        {
            this._state = state;
            this._date = DateTime.Now;
        }

        public DateTime GetDate()
        {
            return this._date;
        }

        public string GetName()
        {
            return $"{this._date} / ({this._state[..(this._state.Length > 9 ? 9 : this._state.Length)]})...";
        }

        public string GetState()
        {
            return this._state;
        }
    }
}
