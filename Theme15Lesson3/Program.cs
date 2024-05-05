// Тема 15. Урок 3
int[] mas = new int[10];
for (int i = 0; i < mas.Length; i++)
{
    Console.Write($"Введите {i + 1} элемент массива: ");
    mas[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine();
for (int i = 0; i < mas.Length - 1; i++)
{
    for (int j = i + 1; j < mas.Length; j++)
    {
        if (mas[i] > mas[j])
        {
            int temp = mas[i];
            mas[i] = mas[j];
            mas[j] = temp;
        }
    }
}
for (int i = 0; i < mas.Length; i++)
{
    Console.Write(mas[i] + " ");
}
Console.WriteLine();
Console.Write("Введите число для поиска: ");
int num =int.Parse(Console.ReadLine());
bool isFind = false;
for (int i = 0; i < mas.Length; i++)
{
    if (num == mas[i])
    {
        Console.WriteLine($"Индекс элемента {i}");
        isFind = true;
    }
   
}
if (isFind == false) Console.WriteLine("Ошибка, элемент не найден.");
Console.WriteLine();