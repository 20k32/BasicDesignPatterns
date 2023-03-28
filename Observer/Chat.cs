using System;
using System.Collections.Generic;

namespace Observer
{
    public class Chat : IObservable
    {
        private List<IObserver> observers = null!;
        private IObserver currentObserver = null!;

        public Chat()
        {
            observers = new List<IObserver>(3);
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void NotifyObserver(IObserver observer, string Information)
        {
            observer.Update($"[ {currentObserver.Name}, {DateTime.Now} ]\n{Information}");
        }

        public void NotifyObservers(string Information)
        {
            foreach (IObserver observer in observers)
            {
                NotifyObserver(observer, Information);
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
    }
}
