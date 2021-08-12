namespace ObserverPatternWeatherStation
{
    public interface ISubject
    {
        void Subscribe(IObserver observer);
        void Unsubscribe(IObserver observer);
    }
}