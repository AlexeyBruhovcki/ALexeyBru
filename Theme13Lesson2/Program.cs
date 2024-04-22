// Тема 13. Урок 2.
//Задача 1
Random random = new Random();
int i = 0;
while (i < ++i)
{
    int n = random.Next(1, 11);
    Console.WriteLine(n);
    if (n == 7) break;
}
Console.WriteLine();
//Задача 2
int j = 0;
int sum = 0;
while (j < ++j)
{
    Console.Write("Введите целое число: ");
    int num = int.Parse(Console.ReadLine()); 
    sum += num;
    
    if (num == 0) break;
}
Console.WriteLine(sum);