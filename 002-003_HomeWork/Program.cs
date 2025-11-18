//Задача 1:
/*Console.ForegroundColor = ConsoleColor.Green;


int[,] arr = new int[7,8];
Random random = new Random();

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(-100, 100);
    }
}

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write($"{arr[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < arr.GetLength(0); i++)
{
    int minRow = arr[i, 0];

    for (int j = 1; j < arr.GetLength(1); j++)
    {
        if (arr[i, j] < minRow)
            minRow = arr[i, j];
    }

    Console.WriteLine($"Min row {i}: {minRow}");
}*/

//Задача 2:
/*using operations;

Console.Write("Enter the text: ");
string str = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("Operations:");
Console.WriteLine("0 - Stop");
Console.WriteLine("1 - Display");
Console.WriteLine("2 - Count");
Console.WriteLine("3 - Search");
Console.WriteLine("4 - Replace");
Console.WriteLine("5 - Delete");
Console.WriteLine();

int operation = -1; 
while (operation != 0){

    Console.Write("Operation: ");
    operation = Convert.ToInt32(Console.ReadLine()); 
    Operation operationVarioant = (Operation)operation; 
    switch (operationVarioant)
    {
        case Operation.Stop:
            operation = 0;
            break;

        case Operation.Display:
            Console.WriteLine("Current text: ");
            Console.WriteLine(str);
            break;

        case Operation.Count:
            Console.WriteLine($"Characters count: {str.Length}");
            break;

        case Operation.Search:
            Console.Write("Enter the word to search: ");
            string searchWord = Console.ReadLine();

            int index = 0;
            int count = 0;
            List<int> positions = new List<int>();

            while (true)
            {
                int found = str.IndexOf(searchWord, index, StringComparison.OrdinalIgnoreCase);

                if (found == -1)
                    break;

                count++;
                positions.Add(found);

                index = found + searchWord.Length;
            }

            if (count == 0)
            {
                Console.WriteLine("Word not found.");
            }
            else
            {
                Console.WriteLine($"Word \"{searchWord}\" found {count} times.");
                Console.WriteLine("Positions: " + string.Join(", ", positions));
            }
            break;

        case Operation.Replace:
            Console.Write("Enter the word to replace: ");
            string oldWord = Console.ReadLine();
            Console.Write("Enter the new word: ");
            string newWord = Console.ReadLine();

            str = str.Replace(oldWord, newWord);
            Console.WriteLine("Updated text: ");
            Console.WriteLine(str);
            break;

        case Operation.Delete:
            Console.Write("Enter the word to delete: ");
            string wordDelete = Console.ReadLine();
            str = str.Replace(wordDelete, "");

            Console.WriteLine("Updated text:");
            Console.WriteLine(str);
            break;

        default:
            Console.WriteLine("Invalid operation");
            break;
    }

    Console.WriteLine();
}*/