namespace DecoratorLibrary
{
    public class ProgrammerDecorator : AbstractEvolutionDecorator
    {
        public ProgrammerDecorator(Human human) : base(human) { }
        public override string DoIntelligentWork()
        {
            human.ExactWork = " is programming a simle task";
            return human.DoWork();
        }
    }
}
