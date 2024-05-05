// Тема 15. Урок 4
Random random = new Random();
int masLength = random.Next(2, 10);
double[] mas1 = new double[masLength];
double[] mas2 = new double[masLength];
double[] mas3 = new double[masLength];
double[] mas4 = new double[masLength];
Console.Write("Элементы первого массива: ");
for (int i = 0; i < mas1.Length; i++)
{
    mas1[i] = random.Next(10, 100);
    Console.Write(mas1[i] + "  ");
}
Console.WriteLine();
Console.Write("Элементы второго массива: ");
for (int i = 0; i < mas2.Length; i++)
{
    mas2[i] = random.Next(10, 100);
    Console.Write(mas2[i] + "  ");
}
Console.WriteLine();
double[] masAverage12 = new double[mas1.Length];
Console.Write("Среднее арифметическое 1 и 2 массивов: ");
for (int i = 0; i < masAverage12.Length; i++)
{
    masAverage12[i] = (mas1[i] + mas2[i]) / 2;
    Console.Write(masAverage12[i] + "  ");
}
Console.WriteLine();
Console.Write("Элементы третьего массива: ");
for (int i = 0; i < mas3.Length; i++)
{
    mas3[i] = random.Next(10, 100);
    Console.Write(mas3[i] + "  ");
}
Console.WriteLine();
Console.Write("Элементы четвертого массива: ");
for (int i = 0; i < mas4.Length; i++)
{
    mas4[i] = random.Next(10, 100);
    Console.Write(mas4[i] + "  ");
}
Console.WriteLine();
double[] masAverage34 = new double[mas3.Length];
Console.Write("Среднее арифметическое 3 и 4 массивов: ");
for (int i = 0; i < masAverage34.Length; i++)
{
    masAverage34[i] = (mas3[i] + mas4[i]) / 2;
    Console.Write(masAverage34[i] + "  ");
}
Console.WriteLine();
double[] masMulti = new double[masAverage12.Length];
Console.Write("Произведение средних арифметических : ");
for (int i = 0; i < masMulti.Length; i++)
{
    masMulti[i] = masAverage12[i] * masAverage34[i];
    Console.Write(masMulti[i] + "  ");
}
Console.WriteLine();