using System;

namespace DecoratorLibrary
{
    public class Male : Human
    {
        public Male()
        {
            ExactWork = " пытается убить мамонта";
        }

        public override string DoWork()
        {
            return string.Concat("Мужчина", ExactWork);
        }
    }
}
