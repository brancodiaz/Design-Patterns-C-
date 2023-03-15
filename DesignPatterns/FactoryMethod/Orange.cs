using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Orange : IFruit
    {
        public void WhoAmI()
        {
            Console.WriteLine("I'm an Orange, make me juice xd");
        }
    }
}
