using System.Collections.Generic;

namespace ChainOfResponsibility_Servers
{
    public abstract class AbstractServer
    {
        public List<string> Information = null!;

        public string[] SearchResults = null!;

        public abstract void Search(string searchOptions);
    }
}
