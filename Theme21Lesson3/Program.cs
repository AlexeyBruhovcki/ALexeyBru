//Тема 21. Урок 3

using System.Runtime.InteropServices;

string curDirectory = Directory.GetCurrentDirectory();
do
{
    Console.Clear();
    Console.WriteLine("Текущая директория: "+curDirectory);
    string[] dirList = Directory.GetDirectories(curDirectory);
    for(int i = 0; i < dirList.Length; i++)
    {
        Console.WriteLine(dirList[i]);
    }
    Console.Write("Введите название папки для перехода(чтобы вернуться предыдущий каталог введите '--'): ");
    string dirName = Console.ReadLine();
    if (dirName == "--")
    {
        curDirectory = Directory.GetParent(curDirectory).FullName;
    }
    else
    {
        string newDir = Path.Combine(curDirectory, dirName);
        if (Directory.Exists(newDir))
        {
            curDirectory = newDir;
        }
        else
        {
            Console.WriteLine("Такой директории не существует.");
            Console.ReadKey();
        }
    }
}
while (true);


