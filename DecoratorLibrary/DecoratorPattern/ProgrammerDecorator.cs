namespace DecoratorLibrary
{
    public class ProgrammerDecorator : AbstractEvolutionDecorator
    {
        public ProgrammerDecorator(Human human) : base(human) { }
        public override string DoIntelligentWork()
        {
            human.ExactWork = " кодит несложную задачу";
            return human.DoWork();
        }
    }
}
