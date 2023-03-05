namespace DecoratorLibrary
{
    public class FemaleHousekeepingDecorator : AbstractEvolutionDecorator
    {
        public FemaleHousekeepingDecorator(Human human) : base(human) { }
        public override string DoIntelligentWork()
        {
            human.ExactWork = " ухаживает за домашним скотом";
            return human.DoWork();
        }
    }
}
