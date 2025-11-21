namespace _014_Polymorphism
{
    internal class Dog : Animal
    {
        public override void Speak() // Override method - це метод, який перевизначає поведінку базового класу
        {
            Console.WriteLine("Woof! Bark!");
        }
    }
}
