using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    public class WeatherProvider : ISubject
    {
        private readonly IList<IObserver> observers;
        private int temp = 0;
        private int pressure = 0;
        private int humidity = 0;


        public WeatherProvider()
        {
            this.observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in this.observers)
            {
                o.Update(this.temp, this.pressure, this.humidity);
            }
        }

        private void OnMeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements()
        {
            SetHumidity();
            SetTemperature();
            SetPressure();
            OnMeasurementsChanged();
        }

        private int GetTemperature()
        {
            return new Random().Next(40,100);
        }

        private int GetPressure()
        {
            return new Random().Next(40,100);
        }

        private int GetHumidity()
        {
            return new Random().Next(40, 100);
        }

        private void SetTemperature()
        {
            this.temp = GetTemperature();
        }

        private void SetPressure()
        {
            this.pressure = GetPressure();
        }

        private void SetHumidity()
        {
            this.humidity = GetHumidity();
        }
    }
}
