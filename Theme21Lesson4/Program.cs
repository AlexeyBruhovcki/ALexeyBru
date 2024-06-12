// Тема 21. Урок 4.

Console.Write("Введите путь к файлу: ");
string path = Console.ReadLine();
if (File.Exists(path))
{
    Console.Write("Файл найден, удалить? Y/N: ");
    string answer = Console.ReadLine().ToLower();
    switch (answer)
    {
        case "y":
            {
                File.Delete(path);
                Console.WriteLine("Файл удален.");
            }
            break;
        case "n":
            {
                Console.WriteLine("Файл не был удален.");
            }
            break;
        default: break;
    }
}
else Console.WriteLine("Файл не найден.");
