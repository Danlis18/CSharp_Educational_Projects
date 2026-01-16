namespace _028_Ping_Pong
{
    class Ping
    {
        public event EventHandler<CounterEventArgs> PingEvent;

        private Pong pong;
        public void Connect(Pong pong)
        {
            this.pong = pong;
            pong.PongEvent += DoPong;
        }

        public void StartPing(int number)
        {
            PingEvent?.Invoke(this, new CounterEventArgs(number));
        }

        public void DoPong(object sender, CounterEventArgs e)
        {
            if (e.Number == 1)
                Console.WriteLine($"Ping received Pong");
            else
                Console.WriteLine($"Ping received Pong");
            
            if (e.Number < 5)
                StartPing(e.Number + 1);
        }
    }
}
