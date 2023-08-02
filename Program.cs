using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherProvider wp = new WeatherProvider();
            WeatherStation ob = new WeatherStation(wp);
            wp.SetMeasurements();
            ob.Display();

            wp.SetMeasurements();
            ob.Display();
        }
    }
}
