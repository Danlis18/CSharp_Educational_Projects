namespace ClassLib_PC
{
    public class PC
    {
        //4-5 полів(марка, серійний номер тощо);

        public string brand;
        public string serialNumber;
        public string processor;
        public int ramSize;
        public int storageSize;

        //властивості для доступу до полів(з використанням get/set);

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string SerialNumber
        {
            get { return serialNumber; }
            set { serialNumber = value; }
        }
        public string Processor
        {
            get { return processor; }
            set { processor = value; }
        }
        public int RamSize
        {
            get { return ramSize; }
            set { ramSize = value; }
        }
        public int StorageSize
        {
            get { return storageSize; }
            set { storageSize = value; }
        }

        //конструктори(за замовчуванням, з параметрами);
        public PC()
        {
            brand = "Unknown";
            serialNumber = "0000";
            processor = "Unknown";
            ramSize = 0;
            storageSize = 0;
        }

        //методи, що моделюють функціонування ПК(увімкнення/вимкнення, перезавантаження, виведення інформації на екран).

        public void PowerOn()
        {
            Console.WriteLine("PC is powering on!");
        }

        public void PowerOff()
        {
            Console.WriteLine("PC is powering off!");
        }

        public void Restart()
        {
            Console.WriteLine("PC is restarting!");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Serial Number: {serialNumber}");
            Console.WriteLine($"Processor: {processor}");
            Console.WriteLine($"RAM Size: {ramSize} GB");
            Console.WriteLine($"Storage Size: {storageSize} GB");
        }   
    }
}
