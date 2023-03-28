namespace Observer
{
    public interface IObservable
    {
        void SetObserverThatNotifies(IObserver notifiesObserver);
        void AddObserver(IObserver observer);
        void NotifyObservers(string Information);
        void NotifyObserver(IObserver observer, string Information);
        void RemoveObserver(IObserver observer);
    }
}
