using System;

namespace ObserverPatternWeatherStation
{
    public class CurrentConditionsDisplay: IDisplay, IObserver
    {
        private readonly ISubject _weatherData;
        private float _humidity;
        private float _temperature;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.Subscribe(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current Conditions: {_temperature} degree temperature and {_humidity}% humidity");
        }
    }
}