namespace _026_Events
{
    class Handler1
    {
        public void Message()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Handler1: Counter has reached 50.");
            Console.ResetColor();
        }
    }

}
