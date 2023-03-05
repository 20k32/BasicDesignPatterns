namespace DecoratorLibrary
{
    public class Female : Human
    {
        public Female()
        {
            ExactWork = " готовит еду в пещере";
        }
        public override string DoWork()
        {
            return string.Concat("Женщина", ExactWork);
        }
    }
}
