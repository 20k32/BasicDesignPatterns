namespace DecoratorLibrary
{
    public class MaleMechanicDecorator : AbstractEvolutionDecorator
    {
        public MaleMechanicDecorator(Human human) : base(human) { }
        public override string DoIntelligentWork()
        {
            human.ExactWork = " is fixing car well";
            return human.DoWork();
        }
    }
}
