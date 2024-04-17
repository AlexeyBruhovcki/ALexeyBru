//Тема 13.Урок1
Random random = new Random();
int randNum = random.Next(1,6);
int i = 1;
Console.WriteLine(randNum);
while (i <= 3)
{
    Console.WriteLine("Введите целое число от 1 до 5: ");
    int userNum = int.Parse(Console.ReadLine());
    if (userNum == randNum) 
    {
        Console.WriteLine("Победа");
        break;
    } 
   
    else Console.WriteLine($"Поражение, осталось попыток: {3 - i}"); i++;
}
Console.WriteLine($"Компьютер загадал число {randNum}");

