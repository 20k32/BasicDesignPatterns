using System.Windows.Documents;
using System.Collections.Generic;
using System;

namespace CompositeLibrary
{
    // root
    public class SubmarineSkeletonComponent : SubmarineComponent
    {
        public List<SubmarineComponent> SubmarineComponents = null!;

        private bool Validate(SubmarineComponent component) => SubmarineComponents.Contains(component);

        public SubmarineSkeletonComponent(string name, int weight) : base(name, weight)
        { 
            SubmarineComponents = new List<SubmarineComponent>();
        }

        public override void Add(SubmarineComponent component)
        {
            if (!Validate(component))
            {
                SubmarineComponents.Add(component);
            }
        }

        public override IEnumerable<SubmarineComponent> GetChildren()
        {
            return SubmarineComponents;
        }

        public override void Remove(SubmarineComponent component)
        {
            if (Validate(component))
            {
                SubmarineComponents.Remove(component);
            }
        }

        public override int GetWeight()
        {
            int result = Weight;

            foreach (SubmarineComponent item in GetChildren())
            {
                result += item.Weight;
                if (item is SubmarineSkeletonComponent subroot)
                {
                    foreach (SubmarineComponent subItem in subroot.GetChildren())
                    {
                        result += subItem.Weight;
                    }
                }
            }
            return result;
        }
    }
}
