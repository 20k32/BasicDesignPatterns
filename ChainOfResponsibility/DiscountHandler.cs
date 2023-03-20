using System;

namespace ChainOfResponsibility
{
    public abstract class DiscountHandler
    {
        public DiscountHandler Successor { get; set; } = null!;
        public abstract void HanldeRequest(AbstractProduct product);
        protected virtual double DiscountPercentage() => 0.05d;
    }


}
