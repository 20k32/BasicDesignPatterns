namespace DecoratorLibrary
{
    public class HouseholdDecorator : AbstractEvolutionDecorator
    {
        public HouseholdDecorator(Human human) : base(human) { }
        public override string DoIntelligentWork()
        {
            human.ExactWork = " делает работу по дому";
            return human.DoWork();
        }
    }
}
