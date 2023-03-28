using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Observer
{
    public class Chat : IObservable, IDoOperationsWithDelay
    {
        private List<IObserver> observers = null!;
        private IObserver currentObserver = null!;
        private int delay = default(int);

        public Chat()
        {
            observers = new List<IObserver>(3);
        }

        public void SetDelay(int value)
        {
            delay = value;
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void DoDelay()
        {
            Thread.Sleep(TimeSpan.FromSeconds(delay));
        }

        public void NotifyObserverSync(IObserver observer, string Information)
        {
            DoDelay();
            observer.Update($"[ {currentObserver.Name}, {DateTime.Now} ]\n{Information}");
        }

        public void NotifyObserversSync(string Information)
        {
            foreach (IObserver observer in observers)
            {
                NotifyObserverSync(observer, Information);
            }
        }


        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void SetObserverThatNotifies(IObserver notifiesObserver)
        {
            currentObserver = notifiesObserver;
        }

        public async Task NotifyObserverAsync(IObserver observer, string Information)
        {
            await Task.Run(() =>
            {
                NotifyObserverSync(observer, Information);
            });
        }

        public async Task NotifyObserversAsync(string Information)
        {
            foreach (IObserver observer in observers)
            {
                await NotifyObserverAsync(observer, Information);
            }
        }
    }
}
