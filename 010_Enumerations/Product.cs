
namespace _010_Enumerations
{
    internal class Product
    {
        public static double CalculatTotalPrice(double price, Discount discount)
        { 
            return price - price / 100 * (int)discount; 
        }
    }
}
