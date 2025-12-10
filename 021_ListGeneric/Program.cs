using _021_ListGeneric;

MyList<int> vector = new MyList<int>();

while (true)
{
    Console.WriteLine("\n--- LIST MENU ---");
    Console.WriteLine("1 - Add element to the end (PushBack)");
    Console.WriteLine("2 - Remove element from the end (PopBack)");
    Console.WriteLine("3 - Insert element by index (Insert)");
    Console.WriteLine("4 - Erase element by index (Erase)");
    Console.WriteLine("5 - Show element by index (At)");
    Console.WriteLine("6 - Reverse list (Reverse)");
    Console.WriteLine("7 - Clear list (Clear)");
    Console.WriteLine("8 - Check if list is empty (Empty)");
    Console.WriteLine("9 - Print list (ToString)");
    Console.WriteLine("10 - Change element using indexer []");
    Console.WriteLine("0 - Exit");
    Console.Write("Your choice: ");

    int choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    try
    {
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
                Console.WriteLine("List reversed.");
                break;

            case 7:
                vector.Clear();
                Console.WriteLine("List cleared.");
                break;

            case 8:
                Console.WriteLine(vector.isEmpty());
                if (vector.isEmpty())
                {
                    Console.WriteLine("List is empty.");
                }
                else
                {
                    Console.WriteLine($"List is NOT empty. Count = {vector.Count}");
                }
                break;

            case 9:
                foreach (var item in vector)
                {
                    Console.WriteLine($"List: {item}, ");
                }
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