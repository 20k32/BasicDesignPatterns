using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class FoodProductDiscountHandler : DiscountHandler
    {
        protected override double DiscountPercentage() => 0.1d;

        public override void HanldeRequest(AbstractProduct product)
        {
            if (product is FoodProduct)
            {
                product.Price -= product.Price * DiscountPercentage();
            }
        }
    }
}
