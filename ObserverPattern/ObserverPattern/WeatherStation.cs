using System;
namespace ObserverPattern
{
    public class WeatherStation
    {
        public static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay display = new CurrentConditionsDisplay(weatherData);
            weatherData.SetMeasurements(80, 65, 33);
            weatherData.SetMeasurements(88, 63, 31);
            return;
        }
    }
}
