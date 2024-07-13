//Тема 27. Урок 1
using Theme27Lesson1;
RubleConverter converter = new RubleConverter();
decimal rubles;
Console.Write("Введите количество рублей: ");
decimal.TryParse(Console.ReadLine(), out rubles);
decimal rublesToDollar = converter.ToDollars(rubles);
Console.WriteLine($"В долларах: {rublesToDollar:F2}");
decimal rublesToEuro = converter.ToEuros(rubles);
Console.WriteLine($"В евро: {rublesToEuro:F2}");
decimal rublesToZloty = converter.ToZlotys(rubles);
Console.WriteLine($"В злотых: {rublesToZloty:F2}");
decimal rublesToYuan = converter.ToYuan(rubles);
Console.WriteLine($"В юанях: {rublesToYuan:F2}");
decimal rublesToRupi = converter.ToRupes(rubles);
Console.WriteLine($"В рупи: {rublesToRupi:F2}");
