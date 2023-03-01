namespace DecoratorLibrary
{
    public class FemaleITTeacher : AbstractEvolutionDecorator
    {
        public FemaleITTeacher(Human human) : base(human) { }
        public override string DoIntelligentWork()
        {
            human.ExactWork = " is coding information system for school";
            return human.DoWork();
        }
    }
}
