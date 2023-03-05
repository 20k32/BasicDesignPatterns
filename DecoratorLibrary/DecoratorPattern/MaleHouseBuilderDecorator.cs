namespace DecoratorLibrary
{
    public class MaleHouseBuilderDecorator : AbstractEvolutionDecorator
    {
        public MaleHouseBuilderDecorator(Human human) : base(human) { }
        public override string DoIntelligentWork()
        {
            human.ExactWork = " строит простой деревянный дом";
            return human.DoWork();
        }
    }
}
