using System.Collections.Generic;

namespace CompositeLibrary
{
    public abstract class SubmarineComponent
    {
        public string Name { get; private set; } = null!;
        public int Weight { get; set; } 

        public SubmarineComponent(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }

        public abstract void Add(SubmarineComponent component);
        public abstract void Remove(SubmarineComponent component);
        public abstract IEnumerable<SubmarineComponent> GetChildren();
    }
}
