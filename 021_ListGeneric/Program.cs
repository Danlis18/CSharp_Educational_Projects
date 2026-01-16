using _021_ListGeneric;

MyList<int> list = new MyList<int>();

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
    Console.WriteLine("9 - Print list (foreach)");
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
                list.PushBack(value);
                Console.WriteLine("Element added.");
                break;

            case 2:
                list.PopBack();
                Console.WriteLine("Last element removed.");
                break;

            case 3:
                Console.Write("Enter index for insertion: ");
                int idxInsert = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter value: ");
                int valInsert = Convert.ToInt32(Console.ReadLine());
                list.Insert(idxInsert, valInsert);
                Console.WriteLine("Element inserted.");
                break;

            case 4:
                Console.Write("Enter index for deletion: ");
                int idxErase = Convert.ToInt32(Console.ReadLine());
                list.Erase(idxErase);
                Console.WriteLine("Element erased.");
                break;

            case 5:
                Console.Write("Enter index: ");
                int idxAt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Element[{idxAt}] = {list.At(idxAt)}");
                break;

            case 6:
                list.Reverse();
                Console.WriteLine("List reversed.");
                break;

            case 7:
                list.Clear();
                Console.WriteLine("List cleared.");
                break;

            case 8:
                if (list.isEmpty())
                    Console.WriteLine("List is empty.");
                else
                    Console.WriteLine($"List is NOT empty. Count = {list.Count}");
                break;

            case 9:
                Console.Write("List: ");
                foreach (var item in list)
                    Console.Write(item + " ");
                Console.WriteLine();
                break;

            case 10:
                Console.Write("Enter index: ");
                int idxSet = Convert.ToInt32(Console.ReadLine());
                Console.Write("New value: ");
                int valSet = Convert.ToInt32(Console.ReadLine());
                list[idxSet] = valSet;
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
