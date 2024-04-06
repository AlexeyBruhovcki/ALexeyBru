// Тема . Урок 1. Задание 1.
Console.WriteLine("Задание 1");
Console.Write($"Результат логического умножения 8х3 равен {8 & 3}\n");
Console.Write($"Результат логического умножения 22х4 равен {22 & 4}\n");
Console.WriteLine("Задание 2");
//Задание 2.
Console.Write($"Результат логического умножения 65|29 равен {65 | 29}\n");
Console.Write($"Результат логического умножения 44|12 равен {44 | 12}\n");
//Задание 3.
Console.WriteLine("Задание 3");
Console.WriteLine($"Результат логического исключения 249 ^ 8 равен {249 ^ 8}");
Console.WriteLine(241 ^ 8);
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Введите ключ: ");
int key = int.Parse(Console.ReadLine());
int encrypt = num ^ key;
int decrypt = encrypt ^ key;
Console.WriteLine($"Зашифрованное число: {encrypt}");
Console.WriteLine($"Расшифрованное число: {decrypt}");