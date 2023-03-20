namespace ChainOfResponsibility
{
    public class FoodProduct : AbstractProduct
    {
        public FoodProduct(string name, string description, double price) : base(name, description, price)
        {
        }
    }
}
