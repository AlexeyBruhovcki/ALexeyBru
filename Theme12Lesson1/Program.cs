// Тема 12. Урок 1.
Console.Write("Введите первое число: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double b = double.Parse(Console.ReadLine());
Console.Write("Выберите операцию: \n" +
    "1 - сложение\n" +
    "2 - вычитание\n" +
    "3 - умножение\n" +
    "4 - деление\n");
int n = int.Parse(Console.ReadLine());
switch (n)
{
    case 1: Console.WriteLine($"{a}+{b}={a+b}"); break;
    case 2: Console.WriteLine($"{a}-{b}={a - b}"); break;
    case 3: Console.WriteLine($"{a}*{b}={a * b}"); break;
    case 4: Console.WriteLine($"{a}/{b}={a / b}"); break;
}

