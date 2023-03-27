using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{

    public class TVNews : ISubject
    {
        Guid _guid = Guid.NewGuid();
        List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            _guid = Guid.NewGuid();
            Console.WriteLine($"Breaking news ID: {_guid.ToString()}");
            Console.WriteLine($"------------------------------------");

            foreach (IObserver observer in _observers)
            {
                observer.Update(_guid.ToString());
            }
            Console.WriteLine();

        }
    }
}
