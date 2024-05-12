//Тема 17. Урок 2.
Random random = new Random();
int[][] mas = new int[3][];
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = new int[random.Next(1, 11)];
}
int count = 0;
double sumAll = 0;
for (int i = 0; i < mas.Length; i++)
{
    int sum = 0;
    for (int j = 0; j < mas[i].Length; j++)
    {

        mas[i][j] = random.Next(1, 11);
        sum += mas[i][j];
        sumAll+= mas[i][j];
        count++;
        Console.Write(mas[i][j] + " ");
    }
    Console.Write("Сумма элементов одномерного массива"+" "+sum);
    Console.WriteLine();
}
Console.WriteLine();
Console.Write($"Среднее арифметическое всех элементов массива: {sumAll/count:F2}");
