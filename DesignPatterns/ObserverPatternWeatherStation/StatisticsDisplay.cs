using System;

namespace ObserverPatternWeatherStation
{
    public class StatisticsDisplay: IObserver, IDisplay
    {
        private float _maxTemp = float.MinValue;
        private float _minTemp = float.MaxValue;
        private float _tempSum = 0.0f;
        private float _numOfReadings = 0;
        
        private readonly ISubject _weatherData;

        public StatisticsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.Subscribe(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _maxTemp = Math.Max(temperature, _maxTemp);
            _minTemp = Math.Min(temperature, _minTemp);
            _tempSum += temperature;
            _numOfReadings++;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("\nTemperature Statistics:");
            Console.WriteLine($"Max Temperature: {_maxTemp}, Min Temperature: {_minTemp}," +
                              $" Avg Temperature: {_tempSum/_numOfReadings}\n");
        }
    }
}