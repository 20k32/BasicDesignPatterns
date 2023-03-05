namespace DecoratorLibrary
{
    public class MaleEngineerDecorator : AbstractEvolutionDecorator
    {
        public MaleEngineerDecorator(Human human) : base(human) { }

        public override string DoIntelligentWork()
        {
            human.ExactWork = " изобретает первый компьютер";
            return human.DoWork();
        }
    }
}
