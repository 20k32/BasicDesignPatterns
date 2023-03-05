namespace DecoratorLibrary
{
    public class FemaleCalculatorDecorator : AbstractEvolutionDecorator
    {
        public FemaleCalculatorDecorator(Human human) : base(human) { }
        public override string DoIntelligentWork()
        {
            human.ExactWork = " делает расчёты в NASA";
            return human.DoWork();
        }
    }
}
