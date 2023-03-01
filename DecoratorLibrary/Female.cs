namespace DecoratorLibrary
{
    public class Female : Human
    {
        public Female()
        {
            ExactWork = " is cooking in the cave";
        }
        public override string DoWork()
        {
            return string.Concat(nameof(Female), ExactWork);
        }
    }
}
