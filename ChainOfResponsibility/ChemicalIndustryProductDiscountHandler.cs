using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class ChemicalIndustryProductDiscountHandler : DiscountHandler
    {
        protected override double DiscountPercentage() => 0.2d;

        public override void HanldeRequest(AbstractProduct product)
        {
            if (product is ChemicalIndustryProduct)
            {
                product.Price -= product.Price * DiscountPercentage();
            }
        }
    }
}
