using System;
namespace ObserverPattern
{
    public class WeatherStation : IObserver, IDisplay
    {
        private ISubject wp;
        private int temp;
        private int pressure;
        private int humidity;


        public WeatherStation(ISubject weatherProvider)
        {
            this.wp = weatherProvider;
            this.wp.RegisterObserver(this);
        }

        public void Update(int temp, int pressure, int humidity)
        {
            this.temp = temp;
            this.pressure = pressure;
            this.humidity = humidity;
        }

        public void Display()
        {
            Console.WriteLine(String.Format("T:{0}, P:{1}, H:{2}", this.temp.ToString(), this.pressure.ToString(), this.humidity.ToString()));
        }
    }
}
