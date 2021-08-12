using System;
using System.Collections.Generic;

namespace ObserverPatternWeatherStation
{
    public class WeatherData: ISubject, INotifier
    {
        private float Temperature { get; set; }
        private float Humidity { get; set; }
        private float Pressure { get; set; }

        private readonly List<IObserver> _observers;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        private void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            Console.WriteLine("Setting new measurements");
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            MeasurementsChanged();
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(Temperature, Humidity, Pressure);
            }
        }

        public void Subscribe(IObserver observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
        }

        public void Unsubscribe(IObserver observer)
        {
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
            }
        }
    }
}