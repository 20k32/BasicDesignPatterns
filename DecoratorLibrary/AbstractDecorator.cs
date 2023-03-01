namespace DecoratorLibrary
{
    public abstract class AbstractDecorator
    {
        private Human human = null!;
        
        public AbstractDecorator(Human Human)
        {
            human = Human;
        }

        public AbstractDecorator() { }

        public void SetObjectToDecorate(Human Human)
        {
            human = Human;
        }

        public abstract void Operation();
    }
}
