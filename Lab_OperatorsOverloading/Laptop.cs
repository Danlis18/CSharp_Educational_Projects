using System.Xml.Linq;

namespace Lab_OperatorsOverloading
{
    class Laptop
    {
        string vendor;
        double price;

        public string Vendor
        {
            get { return vendor; }
            set { vendor = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public override string ToString()
        {
            return $"Vendor: {vendor}, Price: {price}$";
        }
    }
}
