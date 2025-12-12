namespace _026_EventsPractice
{
    class Person
    {
        public event EventHandler<BuyEventArgs> buyEvent;
        public string Name { get; set; }
        public int Age { get; set; }

        public void Buy()
        {
            buyEvent?.Invoke(this, new BuyEventArgs { Age = this.Age });
        }

    }

}
