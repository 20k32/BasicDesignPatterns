namespace DecoratorLibrary
{
    public abstract class AbstractEvolutionDecorator
    {
        protected Human human = null!;

        public AbstractEvolutionDecorator(Human Human)
        {
            human = Human;
        }

        public AbstractEvolutionDecorator()
        { }

        public void SetDecortationObject(Human Human)
        {
            human = Human;
        }

        public abstract string DoIntelligentWork();
    }
}
