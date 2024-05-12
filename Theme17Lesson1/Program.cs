//Тема 17. Урок 1.
Random random = new Random();
int[][] mas = new int[random.Next(1, 11)][];
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = new int[random.Next(1, 11)];
}
for (int i = 0; i < mas.Length; i++)
{
    for (int j = 0; j < mas[i].Length; j++)
    {
        mas[i][j] = random.Next(1, 10);
        Console.Write(mas[i][j] + " ");
    }
    Console.WriteLine();
}
Console.Write("Введите число для замены случайного элемента: ");
int num = int.Parse(Console.ReadLine());
int k = 0;
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas[i].Length; j++)
    {
         if (k < 1)
        {
            int l = random.Next(mas.GetLength(0));
            int m = random.Next(mas[l].Length);
            mas[l][m] = num;
            k++;
        }
        Console.Write(mas[i][j] + " ");
    }
    Console.WriteLine();
}


