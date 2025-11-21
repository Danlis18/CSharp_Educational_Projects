namespace _014_Polymorphism
{
    abstract class Animal // Abstract class - це клас, який не може бути інстанційований безпосередньо
    {
        public uint Age { get; set; }
        public abstract void Speak(); // Abstract method - це метод, який не має реалізації в базовому класі
    }
}
