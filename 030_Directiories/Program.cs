// Directory

//Створення папки
/*string path = @"Folder1/image";
Directory.CreateDirectory(path);*/

//Виалення папки
/*string path = @"Folder1\image";
Directory.Delete(path, true);*/

//Переіменування папки
/*string pathFrom = @"Folder1\Video";
string pathTO = pathFrom + "_New";
Directory.Move(pathFrom, pathTO);*/

//Переміщення папки
/*string pathFrom = @"Folder1\Video_New";
string pathTO = @"Folder1\1\Video_New";
Directory.Move(pathFrom, pathTO);*/

//Перевірити чи існує папка
/*string path= @"Folder1\1\Video_New";
Directory.Exists(path);

if (Directory.Exists(path))
{
    Console.WriteLine("Папка iснує");
}
else
{
    Console.WriteLine("Папка не iснує");
}*/

//Дістаємо інформацію, яка батьківська папка
/*using System.Reflection.Metadata.Ecma335;

string path = @"Folder1\1\Video_New";

DirectoryInfo directoryInfo = new DirectoryInfo(path);
Console.WriteLine("Батькiвська папка: " + directoryInfo.Parent.FullName);
Console.WriteLine("Коренева папка для всіх папок: " + directoryInfo.Root.Name);*/

//Перелік логічних дисків
/*string[] drives = Directory.GetLogicalDrives();
foreach (string drive in drives)
{
    Console.WriteLine(drive);
}*/

//Перелік папок у вказаній папці
/*string path = @"C:\";
string[] directories = Directory.GetDirectories(path);

foreach (string directory in directories)
{
    DirectoryInfo dirInfo = new DirectoryInfo(directory);
    Console.WriteLine(dirInfo.FullName);
}*/

//Перелік вайлів у вказаній папці
/*string path = @"Folder1";
string[] files = Directory.GetFiles(path);

foreach (string file in files)
{
    FileInfo fileInfo = new FileInfo(file);
    Console.WriteLine(fileInfo.FullName);
}*/

//Вивод усіх файлів та папок у вказаній папці
/*string path = @"Folder1";
string[] entries = Directory.GetFileSystemEntries(path);

foreach (string entry in entries)
{
    Console.WriteLine(entry);

    if (Directory.Exists(entry))
    {
        Console.WriteLine(entry + " - це папка");
    }
    else
    {
        Console.WriteLine(entry + " - це файл");
    }
}*/



//File
//Створення текстового файлу з вмістом
//Створення файлу
/*string path = @"Folder1\file32.txt";
File.Create(path);*/

//Видалення файлу
/*string path = @"Folder1\file32.txt";
File.Delete(path);*/

//Копіювання файлу на рівень вище
/*string pathFrom = @"Folder1\1\file1.txt";
string pathTo = @"Folder1\file1.txt";
File.Copy(pathFrom, pathTo);*/


//DirectoryInfo
//Створення папки за допомогою DirectoryInfo
/*string path = @"Folder1\NewFolder";
DirectoryInfo directoryInfo = new DirectoryInfo(path);
Console.WriteLine(directoryInfo.Name);
Console.WriteLine(directoryInfo.FullName);
Console.WriteLine(directoryInfo.CreationTime);
Console.WriteLine(directoryInfo.LastWriteTime);
*/


//FileInfo 
//Створення файлу за допомогою FileInfo
/*string path = @"Folder1\fileInfo.txt";
FileInfo fileInfo = new FileInfo(path);
//fileInfo.Create();
Console.WriteLine(fileInfo.Name);
Console.WriteLine(fileInfo.FullName);*/


//Знаходження шуканого файлу 
/*void FindFiles(string failName, DirectoryInfo root)
{
    try
    {
        foreach (FileInfo file in root.GetFiles())
        {
            if (file.Name == failName)
            {
                Console.WriteLine($"Файл знайдено: {file.FullName}");
                File.Delete(file.FullName);
            }
        }
        foreach (DirectoryInfo directory in root.GetDirectories())
        {
            FindFiles(failName, directory);
        }
    }
    catch (UnauthorizedAccessException ex)
    {
        Console.WriteLine(ex.Message);
    }
}


Console.Write("Введіть ім'я файлу для пошуку: ");
string fileName = Console.ReadLine();

Console.Write("Введіть шлях де шукати: ");
string directoryPath = Console.ReadLine();

DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);
FindFiles(fileName, directoryInfo);*/