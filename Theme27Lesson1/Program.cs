//Тема 27. Урок 1
using Theme27Lesson1;

decimal rubles;
Console.Write("Введите количество рублей: ");
decimal.TryParse(Console.ReadLine(), out rubles);
decimal rublesToDollar = RubleConverter.ToDollars(rubles);
Console.WriteLine($"В долларах: {rublesToDollar:F2}");
decimal rublesToEuro = RubleConverter.ToEuros(rubles);
Console.WriteLine($"В евро: {rublesToEuro:F2}");
decimal rublesToZloty = RubleConverter.ToZlotys(rubles);
Console.WriteLine($"В злотых: {rublesToZloty:F2}");
decimal rublesToYuan = RubleConverter.ToYuan(rubles);
Console.WriteLine($"В юанях: {rublesToYuan:F2}");
decimal rublesToRupi = RubleConverter.ToRupes(rubles);
Console.WriteLine($"В рупи: {rublesToRupi:F2}");
