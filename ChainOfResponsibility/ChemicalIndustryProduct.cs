namespace ChainOfResponsibility
{
    public class ChemicalIndustryProduct : AbstractProduct
    {
        public ChemicalIndustryProduct(string name, string description, double price) : base(name, description, price)
        {
        }
    }
}
