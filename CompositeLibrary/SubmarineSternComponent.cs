using System.Collections.Generic;
using System.Windows.Controls;

namespace CompositeLibrary
{

    // leafe
    public class SubmarineSternComponent : SubmarineComponent
    {
        private Image mainImage = null!;

        public SubmarineSternComponent(string name, int weight, Image MainImage = null!) : base(name, weight)
        {
            mainImage = MainImage;
        }

        public override void Add(SubmarineComponent component)
        {
            throw new System.NotImplementedException();
        }

        public override IEnumerable<SubmarineComponent> GetChildren()
        {
            throw new System.NotImplementedException();
        }

        public override int GetWeight()
        {
            throw new System.NotImplementedException();
        }

        public override void Remove(SubmarineComponent component)
        {
            throw new System.NotImplementedException();
        }

        public void ShowSubmarine(Image image)
        {
            mainImage = image;
        }
    }
}
