
namespace DecoratorLibrary
{
    public class FemalePrinterDecorator : AbstractEvolutionDecorator
    {
        public FemalePrinterDecorator(Human human) : base(human) { }
        public override string DoIntelligentWork()
        {
            human.ExactWork = " работает печатником в суде";
            return human.DoWork();
        }
    }
}
