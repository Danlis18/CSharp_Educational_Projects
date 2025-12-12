namespace _028_Ping_Pong
{
    class CounterEventArgs : EventArgs
    {
        public int Number { get; }

        public CounterEventArgs(int number)
        {
            Number = number;
        }
    }

}
