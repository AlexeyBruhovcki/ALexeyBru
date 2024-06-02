using System.IO;
string fileName = Console.ReadLine();
string path = "C:/Users/doeja/OneDrive/Рабочий стол/File";
path = path + "/" + fileName;
bool program = true;
do
{ 
    Console.Clear();
    if (File.Exists(path))
    {
        Console.WriteLine("Файл найден,удалить файл? ");
        string n = Console.ReadLine();
        switch (n)
        {
            case "+":
                {
                    File.Delete(path);
                    Console.WriteLine("Файл удален");
                    program = false;
                }
                break;
            case "-":
                {
                    Console.WriteLine("Файл не удален");
                    program = false;
                }
                break;
            default:
                {
                    Console.WriteLine("Неверный символ");
                }
                break;

        }
    }
    else
    {
        Console.WriteLine("Файл не найден");
        program = false;
    }
}
while (program==true);
//if (File.Exists(path))
//{
//    Console.WriteLine("Файл найден,удалить файл? ");
//    string n = Console.ReadLine();
//    switch (n)
//    {
//        case "+":
//            {
//                File.Delete(path);
//                Console.WriteLine("Файл удален");
//            }
//            break;
//        case "-":
//            {
//                Console.WriteLine("Файл не удален");
//            }
//            break;
//        default:
//            {
//                Console.WriteLine("Неверный символ");
//            }
//            break;

//    }
//}
//else Console.WriteLine("Файл не найден");
