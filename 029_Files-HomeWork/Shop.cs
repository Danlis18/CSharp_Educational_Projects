

namespace _029_Files_HomeWork
{
    public class Shop
    {
        public string Name { get; set; }
        public List<Product> ListOfProducts { get; set; } = new();

        public Shop() { }

        public Shop(string name, List<Product> listOfProducts)
        {
            Name = name;
            ListOfProducts = listOfProducts;
        }
    }
}
