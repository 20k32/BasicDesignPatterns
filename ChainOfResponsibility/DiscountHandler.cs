using System;

namespace ChainOfResponsibility
{
    public abstract class DiscountHandler
    {
        public abstract void HanldeRequest(AbstractProduct product);
        protected virtual double DiscountPercentage() => 0.05d;
    }
}
