using System;

namespace DecoratorLibrary
{
    public abstract class Human 
    {
        // protected Action<string> notifyUser = null!;
        public Human() { }
        public abstract string DoWork();
        public string ExactWork { get; set; } = null!;
    }
}
