// Тема 12. Урок 2.
Console.WriteLine("Выберите один из ароматов:\n" +
    "1-Сhanel\n" +
    "2-Dior\n" +
    "3-Tom Ford\n" +
    "4-Gucci\n" +
    "5-Yves Saint Lauren\n");

int n =int.Parse(Console.ReadLine());
switch (n)
{
    case 1: Console.WriteLine("Аромат жасмина, розы, сандала и ванили."); break;
    case 2: Console.WriteLine("Фруктовые аккорды с древесными нотами."); break;
    case 3: Console.WriteLine("Ноты лимона, ромашки, кориандра, базилика, ладанника, коричного дерева, кардамона."); break;
    case 4: Console.WriteLine("Белоцветочный, древесно-мускусный, фруктовый и слегка цитрусовый аромат."); break;
    case 5: Console.WriteLine("Верхние ноты мандарина, чёрной смородины и зелёного красного перца.");break;
}
