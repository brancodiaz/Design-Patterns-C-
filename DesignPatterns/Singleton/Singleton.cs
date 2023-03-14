using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Singleton
    {
        private readonly static Singleton _uniqueInstance = new Singleton();

        private int _counter = 0;
        private Singleton() {}
        public static Singleton getInstance
        {
            get{
                return _uniqueInstance;
            }
        }

        public int addCounter()
        {
            _uniqueInstance._counter += 1;
            return _counter;
        }
    }
}
