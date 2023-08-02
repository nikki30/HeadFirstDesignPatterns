using System;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface ISubject
    {      
        public void RegisterObserver(IObserver observer);
        public void RemoveObserver(IObserver observer);
        public void NotifyObservers();
    }
}
