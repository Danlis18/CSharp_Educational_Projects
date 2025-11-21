namespace _008_009_HomeWork
{
    class TV
    {
        int volume;

        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    volume = value;
                }
                else
                {
                    Console.WriteLine("Value must be in range 0-100");
                }
            }
        }
    }
}
