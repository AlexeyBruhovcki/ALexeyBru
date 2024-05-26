// Тема 20. Урок 1.
Console.Write("Введите 1ое число: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите 2ое число: ");
double b = double.Parse(Console.ReadLine());
double Summ(double first, double second) 
{
    return first + second;
}
Console.Write($"Сумма чисел: {Summ(a,b):F2}");
