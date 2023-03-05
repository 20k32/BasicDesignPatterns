namespace DecoratorLibrary
{
    public class MaleAutoProgrammer : AbstractEvolutionDecorator
    {
        public MaleAutoProgrammer(Human human) : base(human) { }

        public override string DoIntelligentWork()
        {
            human.ExactWork = " программирует информационную систему автомобиля";
            return human.DoWork();
        }
    }
}
