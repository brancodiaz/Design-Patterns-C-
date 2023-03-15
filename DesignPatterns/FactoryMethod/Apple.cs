using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Apple : IFruit
    {
        public void WhoAmI()
        {
            Console.WriteLine("I'm an Apple and my color is red");
        }
    }
}
