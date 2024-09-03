// Тема 33. Урок 1. Сввойства классов.
using Theme33Lesson1;

Operations operations = new Operations();
do
{
    Console.Clear();
    operations.Print();
    Console.Write("Выберите действие:\n" +
    "1 - Удаление по индексу\n" +
    "2 - Поиск по значению\n" +
    "3 - Очистка списка\n" +
    "4 - Добавить значение\n" +
    "5 - Сортировка в алфавитном порядке\n" +
    "6 - Массив индексов вхождения значения\n" +
    "7 - Сумма чисел списка\n" +
    "8 - Сохранить в файл\n" +
    "9 - Загрузить из файла\n");
    int n;
    int.TryParse(Console.ReadLine(), out n);
    switch (n)
    {
        case 1: operations.DeleteByIndex(); break;
        case 2:operations.SearchByValue();break;
        case 3:operations.Clear(); break;
        case 4:operations.AddValue(); break;
        case 5:operations.Sort();break;
        case 6:operations.FindAllValues(); break;
        case 7:operations.Summ(); break;
        case 8:operations.SaveToFile(); break;
        case 9:operations.LoadFromFile();break;
    }
    Console.ReadKey();
}
while(true);