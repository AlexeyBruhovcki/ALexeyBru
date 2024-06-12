//Тема 21. Урок 1.

Console.Write("Введите путь к файлу: ");
string path = Console.ReadLine();
FileInfo file = new FileInfo(path);
if (file.Exists)
{
    Console.Write("Введите текст для записи в файл: ");
    string text = Console.ReadLine();
    using (StreamWriter writer = new StreamWriter(path, false))
    {
        await writer.WriteAsync(text);
        Console.WriteLine("Файл успешно записан.");
    }
}
else Console.WriteLine("Файл не существует");
void FileCreat()
{
    Console.Write("Введите путь создаваемого файла: ");
    string path = Console.ReadLine();
    Console.Write("Введите имя создаваемого файла: ");
    string filename= Console.ReadLine();
    filename=path+ @"\" + filename;
    FileInfo fileInfo = new FileInfo(filename);
    if (!fileInfo.Exists) fileInfo.Create();
    else Console.WriteLine("Файл существует");
}
FileCreat();
FileCreat();
Console.WriteLine("Содержимое первого файла: "+ PrintText(path)); 
string PrintText(string path)
{
    return File.ReadAllText(path);
}