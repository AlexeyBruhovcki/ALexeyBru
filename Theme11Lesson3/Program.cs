//Тема 11.Урок 3.
//Задание 1
using System.Security.Cryptography;

Random random = new Random();
Console.Write("Введите целое число от 0 до 5: ");
int num = int.Parse(Console.ReadLine());
int randNum = random.Next(6);
if (num <= 5 && num >= 0)
{
    if (randNum == num) Console.WriteLine($"Победа, компьютер выбрал число {randNum}");
    else Console.WriteLine($"Поражение, компьютер выбрал число {randNum}");
}
else Console.WriteLine("Неверное число");

//Задание 2.
Console.WriteLine("Введите порядковый номер месяца: ");
int mounthNum = int.Parse(Console.ReadLine());
Console.WriteLine("Введите среднюю температуру воздуха: ");
double mounthTemp = double.Parse(Console.ReadLine());
switch (mounthNum)
{
    case 1: Console.WriteLine("January"); break;
    case 2: Console.WriteLine("February");break;
    case 3: Console.WriteLine("March");break;
    case 4: Console.WriteLine("April");break;
    case 5: Console.WriteLine("May");break;
    case 6: Console.WriteLine("June");break;
    case 7: Console.WriteLine("July"); break;
    case 8: Console.WriteLine("August");break;
    case 9: Console.WriteLine("September");break;
    case 10: Console.WriteLine("October"); break;
    case 11: Console.WriteLine("November"); break;
    case 12: Console.WriteLine("December");break;
}
if  (mounthTemp > 0&&mounthNum<3||mounthNum>11) Console.WriteLine("Дождливая зима");

