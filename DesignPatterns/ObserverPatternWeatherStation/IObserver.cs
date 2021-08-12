namespace ObserverPatternWeatherStation
{
    public interface IObserver
    {
        void Update(float temp, float humidity, float pressure);
    }
}