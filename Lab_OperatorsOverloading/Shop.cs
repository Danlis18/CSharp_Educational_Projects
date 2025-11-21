namespace Lab_OperatorsOverloading
{
    class Shop
    {
        Laptop[] laptops;

        public Shop(Laptop[] laptops)
        {
            this.laptops = laptops;
        }

        public override string ToString()
        {
            return string.Join("", laptops.Select(l => l.Vendor + " - " + l.Price + "$\n").ToArray());
        }

        public Laptop[] Laptops
        {
            get { return laptops; }
            set { laptops = value; }
        }

        public Laptop this[int index]
        {
            get { return laptops[index]; }
            set
            {
                if (index >= 0 && index < laptops.Length)
                    laptops[index] = value;
            }
        }

        private int FindLaptopByPrice(double price)
        {
            for (int i = 0; i < laptops.Length; i++)
            {
                if (laptops[i].Price == price)
                    return i;
            }
            return -1;
        }

        public Laptop this[double price]
        {
            get { return laptops[FindLaptopByPrice(price)]; }
            set
            {
                int index = FindLaptopByPrice(price);
                if (index != -1)
                    laptops[index] = value;
            }
        }

        private int FindLaptopByVendor(string vendor)
        {
            for (int i = 0; i < laptops.Length; i++)
            {
                if (laptops[i].Vendor == vendor)
                    return i;
            }
            return -1;
        }

        public Laptop this[string vendor]
        {
            get { return laptops[FindLaptopByVendor(vendor)]; }
            set
            {
                int index = FindLaptopByVendor(vendor);
                if (index != -1)
                    laptops[index] = value;
            }
        }
    }
}
