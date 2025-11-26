using _015_Interface;
Console.ForegroundColor = ConsoleColor.DarkGreen;
//Інтерфейс містить властивості, методи та події, реалізацію яких зобовязуються здійснити класи-наступники цього інтерфейсу.
//На С# тип може наслідувати лише один клас, але може реалізовувати багато інтерфейсів.

/*Manager manager = new Manager();
manager.Control();
Scientist scientist = new Scientist();
scientist.Investigate();*/

//інтерфейсна силка - це змінна, яка може посилатися на будь-який об'єкт, що реалізує цей інтерфейс
/*IWorker worker = new Teacher();
IWorker scientist = new Scientist();
IWorker manager = new Manager();
worker.Work();
scientist.Relax();*/

/*DoWork(new Scientist());
DoManage(new Manager());
void DoWork(IWorker worker) //інтерфейс який передаємо, точно реалізований в класі який ми передаємо в метод
{
    worker.Work();
}

void DoManage(IManager manager)
{
    manager.Plan();
    manager.Motivate();
}

IWorker[] workers = new IWorker[] { 
    new Teacher(), 
    new Scientist(),
    new Manager()
};

foreach (var worker in workers)
{
    worker.Work();
}*/

//Приведення типу до інтерфейсної силки
/*Scientist scientist = new Scientist();

if(scientist is IScientist)
    (scientist as IScientist).Research(); //приведення до конкретного інтерфейсу

*/


//Іплементація декількох інтерфейсів
MyClass myClass = new MyClass();
((InterfaceTEST1)myClass).TestMethod();
((InterfaceTEST2)myClass).TestMethod();