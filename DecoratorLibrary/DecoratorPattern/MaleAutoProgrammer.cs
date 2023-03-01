namespace DecoratorLibrary
{
    public class MaleAutoProgrammer : AbstractEvolutionDecorator
    {
        public MaleAutoProgrammer(Human human) : base(human) { }

        public override string DoIntelligentWork()
        {
            human.ExactWork = " programs the information system for the car";
            return human.DoWork();
        }
    }
}
