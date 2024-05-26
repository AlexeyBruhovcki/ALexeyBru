//Тема 20. Урок 2.
Random random = new Random();
int[] mas = new int[random.Next(1, 20)];
for(int i = 0; i < mas.Length; i++)
{
    mas[i] = random.Next(1, 20);
    Console.Write(mas[i]+" ");
}
double Average(int[] mas)
{
    double s = 0;
    for(int i = 0; i < mas.Length; i++)
    {
        s += mas[i];
    }
    return s / mas.Length;
}
Console.WriteLine();
Console.WriteLine($"Среднее арифметическое элементов массива: {Average(mas):F2}");
