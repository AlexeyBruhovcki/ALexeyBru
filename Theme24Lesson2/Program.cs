// Тема 24. Урок 2. рекурсия

Console.Write("Введите число: ");
int n;
int.TryParse(Console.ReadLine(), out n);

void DigtsUneven(int n)
{
    if (n <= 0) return;
    DigtsUneven(n - 1);
    if (n % 2 != 0)
    {
        Console.Write(n+" ");
    }
}

DigtsUneven(n);