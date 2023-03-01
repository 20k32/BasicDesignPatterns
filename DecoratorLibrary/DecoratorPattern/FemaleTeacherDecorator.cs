namespace DecoratorLibrary
{
    public class FemaleTeacherDecorator : AbstractEvolutionDecorator
    {
        public FemaleTeacherDecorator(Human human) : base(human) { }
        public override string DoIntelligentWork()
        {
            human.ExactWork = " teaches other humans";
            return human.DoWork();
        }
    }
}
