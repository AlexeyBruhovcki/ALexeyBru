// Тема 20. Локальные функции.
// Задание1
//Console.Write("Введите 1ое число: ");
//double a = double.Parse(Console.ReadLine());
//Console.Write("Введите 2ое число: ");
//double b = double.Parse(Console.ReadLine());
//double Summ(double first, double second)
//{
//    return first + second;
//}
//Console.Write($"Сумма чисел: {Summ(a, b):F2}");

//Задание 2.
Random random = new Random();
Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine());
int[] mas = new int[n];
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = random.Next(20);
    Console.Write(mas[i]+" ");
}
Console.WriteLine();
double MasAverage(int[] mas)
{
    int sum = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        sum += mas[i];
    }
    return (double)sum / mas.Length;
}
Console.WriteLine(MasAverage(mas));