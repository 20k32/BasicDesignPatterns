using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class DecorativeItemDiscountHandler : DiscountHandler
    {
        protected override double DiscountPercentage() => 0.15d;

        public override void HanldeRequest(AbstractProduct product)
        {
            if (product is DecorativeItemProduct)
            {
                product.Price -= product.Price * DiscountPercentage();
            }
        }
    }
}
