namespace DecoratorLibrary
{
    public class FemaleITTeacher : AbstractEvolutionDecorator
    {
        public FemaleITTeacher(Human human) : base(human) { }
        public override string DoIntelligentWork()
        {
            human.ExactWork = " программирует информационную систему для школы";
            return human.DoWork();
        }
    }
}
