//Тема 10. Урок1.
Console.WriteLine($"Введите радиус окружности: ");
double r = double.Parse(Console.ReadLine());
Console.WriteLine($"Длина окружности равна: {2 * Math.PI * r:F2}\n" +
    $"Площадь окружности равна: {Math.PI * r * r:F2}");