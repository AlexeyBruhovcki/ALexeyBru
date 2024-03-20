// Тема 5. Урок 2. Контсанты и литералы.

const double nds18 = 0.18;
const double nds10 = 0.1;
const double coffe_price = 69;
const double roll_price = 70;
const int coffe_count = 1;
const double roll_count = 1;
double coffe_nds = coffe_price * nds18;
double roll_nds = roll_price * nds10;
double summ = coffe_price + roll_price;

Console.Write($"............................................................\n" +
    $" № Название                               Цена  Кол.  Сумма \n" +
    $" 1 КОФЕ СТАНДАРТНЫЙ                      {coffe_price:F2}  {coffe_count:F2}  {(coffe_price * coffe_count):F2}\n" +
    $"   НДС с рассчитанной                                 {coffe_nds}\n" +
    $"   ставкой 18%\n");
Console.Write($" № Название                               Цена  Кол.  Сумма \n" +
    $" 2 РУЛЕТ-СПРИНГ ТВ ИЗ                    {roll_price:F2}  {roll_count:F2}  {(roll_price * roll_count):F2}\n" +
    $"   КУ\n" +
    $"   НДС с рассчитанной                                  {roll_nds:F2}\n" +
    $"   ставкой 10%\n" +
    $"\n" +
    $"\n");
Console.Write($"............................................................\n" +
    $" Итого:                                              {summ:F2}\n" +
    $"\n"+
    $" Электронные средства                                {summ:F2}\n" +
    $" НДС итога чека с                                     {coffe_nds}\n" +
    $" рассчитанной ставкой\n" +
    $" 18%\n" +
    $" НДС итога чека с                                      {roll_nds:F2}\n" +
    $" рассчитанной ставкой\n" +
    $" 10%\n" +
    $" \n");
Console.Write($"............................................................\n" +
    $" ВИД НАЛОГООБЛОЖЕНИЯ: ОСН\n" + 
    $" РЕГ. НОМЕР ККТ: 0000143873023483\n" +
    $" ЗАВОД. №:\n" +
    $" ФН №: 8710000100265168\n" +
    $" ФД №: 6026\n" +
    $" ФПД: 3322278314");




