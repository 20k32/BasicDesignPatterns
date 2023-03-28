using System.Collections;
using System.Collections.Generic;

namespace Observer
{
    public class User : IObserver, IAccessCache
    {
        public string Name { get; set; }

        private List<string> cache = null!;

        public User(string name)
        {
            Name = name;
            cache = new List<string>();
        }

        public void Update(string Information)
        {
            cache.Add(Information);
        }

        public IEnumerable GetCache()
        {
            return cache;
        }
    }
}
