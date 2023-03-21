using System.Collections.Generic;

namespace ChainOfResponsibility_Servers
{

    public abstract class AbstractServer
    {
        protected AbstractServer successor = null!;

        public AbstractServer(AbstractServer Successor)
        {
            successor = Successor;
        }

        protected List<string> Information = null!;

        public string[] SearchResults = null!;

        public abstract void Search(string searchOptions);

        public abstract void SetSuccessor(AbstractServer NewSuccessor);
    }
}
