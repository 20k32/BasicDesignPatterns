namespace DecoratorLibrary
{
    public class MaleDeveloperDecorator : AbstractEvolutionDecorator
    {
        public MaleDeveloperDecorator(Human human) : base(human){ }
        public override string DoIntelligentWork()
        {
            human.ExactWork = " изобретает паровой двигатель";
            return human.DoWork();
        }
    }
}
