// Тема 10. Урок 2.
Console.Write("Введите значение катета: ");
double a=double.Parse(Console.ReadLine());
Console.Write("Введите значение гипотенузы: ");
double c = double.Parse(Console.ReadLine());
Console.WriteLine($"Значение гипотенузы: {Math.Sqrt(c*c-a*a):F2}");