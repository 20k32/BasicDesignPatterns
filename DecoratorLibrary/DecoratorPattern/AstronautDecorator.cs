namespace DecoratorLibrary
{
    public class AstronautDecorator : AbstractEvolutionDecorator
    {
        public AstronautDecorator(Human human) : base(human) { }
        public override string DoIntelligentWork()
        {
            human.ExactWork = " готовится к посадке на луну";
            return human.DoWork();
        }
    }
}
