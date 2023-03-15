using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Banana : IFruit
    {
        public void WhoAmI()
        {
            Console.WriteLine("I'm a Banana. Nice to meet you");
        }
    }
}
