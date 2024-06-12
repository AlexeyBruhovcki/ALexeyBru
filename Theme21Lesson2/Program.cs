//Тема 21. Урок 2.
Console.Write("Введите путь к файлу: ");
string path = Console.ReadLine();
FileInfo file = new FileInfo(path);
if (file.Exists)
{
    Console.WriteLine("Файл существует.");
    Console.WriteLine("Размер в байтах: "+file.Length);
    Console.WriteLine("Дата последнего изменения: " + file.LastWriteTime);
    Console.WriteLine("Расширение файла: " + file.Extension);
}
else Console.WriteLine("Файл не существует.");