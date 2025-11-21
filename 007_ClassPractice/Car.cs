namespace _007_ClassPractice
{
    partial class Car
    {
        private string brand;
        private string name;
        private int year;
        private string color;
        private string owner;
        public static int TotalCars;
        public Car() {
            TotalCars++;
        }

        public Car(string brand, string name, int year, string color, string owner) {
            this.brand = brand;
            this.name = name;
            this.year = year;
            this.color = color;
            this.owner = owner;
            TotalCars++;
        }

        public void CalculatePrice(out double price, out int valueOfOwners)
        { 
            //викинув рандомні формули Copilot
            valueOfOwners = (2024 - year) / 5 + 1;
            price = Math.Max(1000, 30000 - (2024 - year) * 1500 - (valueOfOwners - 1) * 2000);
        }


        public string Brand { get; set; }

        public string Name {get; set;}

        public int Year { get; set; }

        public string Color { get; set; }

        public string Owner { get; set; }


        public override string ToString() {
            return $"Brand: {brand}, Name: {name}, Year: {year}, Color: {color}, Owner: {owner}";
        }

        

    }
}
