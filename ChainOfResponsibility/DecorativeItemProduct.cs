namespace ChainOfResponsibility
{
    public class DecorativeItemProduct : AbstractProduct
    {
        public DecorativeItemProduct(string name, string description, double price) : base(name, description, price)
        {
        }
    }
}
