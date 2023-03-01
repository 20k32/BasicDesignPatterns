using System;

namespace DecoratorLibrary
{
    public class Male : Human
    {
        public Male()
        {
            ExactWork = " is killing mamonth";
        }

        public override string DoWork()
        {
            return string.Concat(nameof(Male), ExactWork);
        }
    }
}
