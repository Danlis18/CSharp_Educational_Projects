using System.Net.NetworkInformation;

namespace _028_Ping_Pong
{
    class Pong
    {
        public event EventHandler<CounterEventArgs> PongEvent;

        private Ping ping;
        public void Connect(Ping ping)
        {
            this.ping = ping;
            ping.PingEvent += DoPing;
        }
        public void StartPong(int number)
        {
            PongEvent?.Invoke(this, new CounterEventArgs(number));
        }
        public void DoPing(object sender, CounterEventArgs e)
        {
            if (e.Number == 2)
                Console.WriteLine($"Pong received Ping");
            else
                Console.WriteLine($"Pong received Ping");

            if (e.Number < 5)
                StartPong(e.Number + 1);
        }
    }
}
