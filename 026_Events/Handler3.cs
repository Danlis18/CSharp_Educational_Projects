namespace _026_Events
{
    internal class Handler3
    {
        public void Message()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Handler3: спрацював");
            Console.ResetColor();
        }
    }
}
