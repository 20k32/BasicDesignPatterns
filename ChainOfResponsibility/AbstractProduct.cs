namespace ChainOfResponsibility
{
    public abstract class AbstractProduct
    {
        public AbstractProduct(string name, string description, double price)
        {
            Name = name;
            Description = description;
            _price = price;
        }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        private double _price;
        public double Price
        {
            get => _price;
            set
            {
                if (_price < 0.1d)
                {
                    _price = 0.1d;
                }
                else
                {
                    _price = value;
                }
            }

        }

        public override string ToString()
        {
            return string.Concat(Name, " ", Description, " ", Price.ToString(), ".");
        }

    }
}
