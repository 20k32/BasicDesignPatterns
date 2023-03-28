using System.Threading.Tasks;

namespace Observer
{
    public interface IObservable
    {
        void SetObserverThatNotifies(IObserver notifiesObserver);
        void AddObserver(IObserver observer);
        void NotifyObserversSync(string Information);
        void NotifyObserverSync(IObserver observer, string Information);
        Task NotifyObserverAsync(IObserver observer, string Information);
        Task NotifyObserversAsync(string Information);
        void RemoveObserver(IObserver observer);
    }
}
