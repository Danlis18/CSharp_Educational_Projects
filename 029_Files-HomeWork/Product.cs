namespace _029_Files_HomeWork
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public Product() { }

        public Product(string name, decimal price, string description)
        {
            Name = name;
            Price = price;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Name}, {Price} ₴, {Description}";
        }
    }
}
