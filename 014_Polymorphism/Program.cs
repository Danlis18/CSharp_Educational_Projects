using _014_Polymorphism;

Animal dog = new Dog(); // Створення об'єкта типу Dog, але з посиланням типу Animal
dog.Speak(); // Виклик методу Speak() для об'єкта Dog

Animal cat = new Cat();
cat.Speak();

/*List<Animal> animals = new List<Animal>
{
    new Dog(),
    new Cat()
};*/