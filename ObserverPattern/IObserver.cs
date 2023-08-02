using System;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface IObserver
    {     
        public void Update(int temp, int pressure, int humidity);
    }
}
