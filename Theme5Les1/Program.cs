// Тема 5. Урок 1. Константы и литералы.

Console.Write("Введите количество милиметров: ");
double mil = double.Parse(Console.ReadLine()); // Ввод количества миллиметров

const int tens = 10;
const double mileK = 1.609344;
const double yardK = 1093.61;

double sant = mil / tens; // Расчет кол-ва сантиметров
double met = sant / Math.Pow(tens, 2); // Расчет кол-ва метров
double kil = met / Math.Pow(tens, 3); // Расчет кол-ва километров
double mile = kil / mileK; // Расчет кол-ва миль
double yard = kil * yardK; // Расчет кол-ва ярдов

Console.Write($"Сантиметры: {sant}\n" +
    $"Метры: {met}\n" +
    $"Километры: {kil}\n" +
    $"Мили: {mile:F5}\n" +
    $"Ярды: {yard:F5}");
