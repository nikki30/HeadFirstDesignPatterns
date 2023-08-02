using System;
namespace ObserverPattern
{
    public class CurrentConditionsDisplay: DisplayElement, IObserver
    {
        private ISubject weatherData;
        private float temp;
        private float hum;
        private float pressure;
        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void update(float temp, float humidity, float pressure)
        {
            this.temp = temp;
            this.hum = humidity;
            this.pressure = pressure;
            display();
        }

        public void display()
        {
            Console.WriteLine(this.temp);
            Console.WriteLine(this.hum);
            Console.WriteLine(this.pressure);
        }
    }
}
