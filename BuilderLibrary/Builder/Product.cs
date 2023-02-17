using Microsoft.VisualBasic;
using Prototype;
using System;
using System.Collections.Generic;

namespace BuilderLibrary
{
    public class Product : IPrototype
    {
        private List<AbstractComputerComponent> ComputerComponents = null!;

        public int ProductsCount => ComputerComponents.Count;

        public Product() 
        {
            ComputerComponents = new List<AbstractComputerComponent>();
        }

        private bool AddValidate() => ProductsCount + 1 < 9 ? true : false;
        private bool RemoveValidate() => ProductsCount - 1 > -1 ? true : false;
        
        public void AddProduct(AbstractComputerComponent computerComponent)
        {
            if (AddValidate())
            {
                ComputerComponents.Add(computerComponent);
            }
        }
        
        public void RemoveProduct(AbstractComputerComponent computerComponent)
        {
            if (RemoveValidate())
            {
                ComputerComponents.Remove(computerComponent);
            }
        }

        public IEnumerable<AbstractComputerComponent> GetPCComponents()
        {
            int i = 0;
            while (i < ProductsCount)
            {
                yield return ComputerComponents[i++];
            }
        }

        public IPrototype DeepCopyClone()
        {
            Product productCopy = new Product();

            foreach (AbstractComputerComponent component in ComputerComponents)
            {
                productCopy.AddProduct(component);
            }

            return productCopy;
        }

        public IPrototype Clone()
        {
            return new Product() { ComputerComponents = this.ComputerComponents };
        }
    }
}
