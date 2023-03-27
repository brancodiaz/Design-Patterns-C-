using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Subscriber : IObserver
    {
        private string _name = string.Empty;

        public Subscriber(string name) => _name = name;

        public void Update(string message)
        {
            Console.WriteLine($"{_name} is reading the following news: {message}" );
        }
    }
}
