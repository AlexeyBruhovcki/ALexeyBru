using System.Security.Cryptography;

Random random = new Random();
int[,] mas1 = new int[4, 4];
int[,] mas2 = new int[4, 4];

void MasPrint(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write(mas[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] MasFill(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i, j] = random.Next(-50, 51);
        }
    }
    return mas;

}
mas1 = MasFill(mas1);
mas2 = MasFill(mas2);
Console.WriteLine("Первый массив: ");
MasPrint(mas1);
Console.WriteLine("Второй массив: ");
MasPrint(mas2);
Console.WriteLine("Массив суммы двух предыдущих: ");
MasPrint(MasSum(mas1, mas2));
Console.WriteLine("Максимальное значение массива: "+MasMax(MasSum(mas1, mas2)));
int[,] MasSum(int[,] mas1, int[,] mas2)
{
    int[,] mas = new int[4, 4];
    for(int i = 0; i< mas.GetLength(0); i++)
    {
        for(int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i, j] = mas1[i, j] + mas2[i, j];
        }
    }
    return mas;
}
int MasMax(int[,] mas)
{
    int maxValue = int.MinValue;
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            if (mas[i, j] > maxValue) maxValue = mas[i, j];
        }
    }
    return maxValue;
}
