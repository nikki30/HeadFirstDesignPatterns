using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    public class WeatherData: ISubject
    {
        private List<IObserver> observers;
        private float temp;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.update(this.temp, this.humidity, this.pressure);
            }
        }

        public void MeasurementsChanged(IObserver o)
        {
            NotifyObservers();
        }

        public void SetMeasurements(float t, float h, float p)
        {
            this.temp = t;
            this.humidity = h;
            this.pressure = p;
        }
    }
}
