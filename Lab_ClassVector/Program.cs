using Lab_ClassVector;

MyVector vector = new MyVector();

while (true)
{
    Console.WriteLine("\n--- VECTOR MENU ---");
    Console.WriteLine("1 - Add element to the end (PushBack)");
    Console.WriteLine("2 - Remove element from the end (PopBack)");
    Console.WriteLine("3 - Insert element by index (Insert)");
    Console.WriteLine("4 - Erase element by index (Erase)");
    Console.WriteLine("5 - Show element by index (At)");
    Console.WriteLine("6 - Reverse vector (Reverse)");
    Console.WriteLine("7 - Clear vector (Clear)");
    Console.WriteLine("8 - Check if vector is empty (Empty)");
    Console.WriteLine("9 - Print vector (ToString)");
    Console.WriteLine("10 - Change element using indexer []");
    Console.WriteLine("0 - Exit");
    Console.Write("Your choice: ");

    int choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    try {
        switch (choice)
        {
            case 1:
                Console.Write("Enter value to add: ");
                int value = Convert.ToInt32(Console.ReadLine());
                vector.PushBack(value);
                Console.WriteLine("Element added.");
                break;

            case 2:
                vector.PopBack();
                break;

            case 3:
                Console.Write("Enter index for insertion: ");
                int idxInsert = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter value: ");
                int valInsert = Convert.ToInt32(Console.ReadLine());
                vector.Insert(idxInsert, valInsert);
                Console.WriteLine("Element inserted.");
                break;

            case 4:
                Console.Write("Enter index for deletion: ");
                int idxErase = Convert.ToInt32(Console.ReadLine());
                vector.Erase(idxErase);
                Console.WriteLine("Element erased.");
                break;

            case 5:
                Console.Write("Enter index: ");
                int idxAt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Element[{idxAt}] = {vector.At(idxAt)}");
                break;

            case 6:
                vector.Reverse();
                Console.WriteLine("Vector reversed.");
                break;

            case 7:
                vector.Clear();
                Console.WriteLine("Vector cleared.");
                break;

            case 8:
                Console.WriteLine(vector.isEmpty());
                    if (vector.isEmpty())
                        {
                            Console.WriteLine("Vector is empty.");
                        }   
                    else
                        {
                            Console.WriteLine($"Vector is NOT empty. Count = {vector.Count}");
                        }
                break;

            case 9:
                Console.WriteLine(vector.ToString());
                break;

            case 10:
                Console.Write("Enter index: ");
                int idxSet = Convert.ToInt32(Console.ReadLine());
                Console.Write("New value: ");
                int valSet = Convert.ToInt32(Console.ReadLine());
                vector[idxSet] = valSet;
                Console.WriteLine("Element changed using indexer.");
                break;

            case 0:
                return;

            default:
                Console.WriteLine("Invalid menu item.");
                break;
        }
    }
    catch (Exception exception)
    {
        Console.WriteLine("Error: " + exception.Message);
    }
}
