using System;

namespace ObserverPatternWeatherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WeatherStation Simulator\n");

            var weatherData = new WeatherData();
            var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            var statisticsDisplay = new StatisticsDisplay(weatherData);
            
            weatherData.SetMeasurements(35, 20, 10);
            weatherData.SetMeasurements(40, 25, 16);
            weatherData.SetMeasurements(37, 21, 10);
            weatherData.SetMeasurements(35, 20, 10);
            
            weatherData.Unsubscribe(statisticsDisplay);
            weatherData.SetMeasurements(40, 25, 16);
        }
    }
}