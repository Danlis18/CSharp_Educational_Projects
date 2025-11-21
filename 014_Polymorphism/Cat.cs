namespace _014_Polymorphism
{
    internal class Cat : Animal
    {
        public override void Speak() // Override method - це метод, який перевизначає поведінку базового класу
        {
            Console.WriteLine("Meow! Purr!");
        }
    }
}
