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
            if (SetChanged())
            {
                NotifyObservers();
            }
        }

        private bool SetChanged()
        {
            // if some criteria is met, then setChanged is updated to true, else false.
            // This helps to control how many notifications the observer receives. For example, if delta change in temp is > 3 degress, only then inform customer.
            // One more benefit is we can choose to NotifyObservers(with changed args) or just NotifyObservers() - this allows them to 'pull' data if they want.
            // Instead of Subject pushing data.
            return true;
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
