//Тема 20. Урок 3.

int LogicOperation(int n,int x, int y = 0)
{
    if (n == 1) return x & y;
    else if (n == 2) return x | y;
    else if (n == 3) return x ^ y;
    else if (n == 4) return ~x;
    else return 0; 
}
bool program = true;
do
{
    int n;
    Console.Clear();
    Console.Write("Выберите действие: \n" +
        "1 - Логическое умножение\n" +
        "2 - Логическое сложение\n" +
        "3 - Шифрование по ключу\n" +
        "4 - Инверсия\n" +
        "5 - Выход\n");
    if (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.WriteLine("Некорректный ввод, введите число от 1 до 5, нажмите юбую клавишу, чтобы продолжить");
        
    }
    else
    {
        int x = 0;
        int y = 0;
        switch (n)
        {
            case 1:
                {
                    //int x = 0;
                    //int y = 0;
                    NumbInput(n, ref x, ref y);
                    Console.WriteLine("Результат: " + LogicOperation(n, x, y));
                }; break;
            case 2:
                {
                    //int x = 0;
                    //int y = 0;
                    NumbInput(n, ref x, ref y);
                    Console.WriteLine("Результат: "+LogicOperation(n, x, y));
                }; break;
            case 3:
                {
                    //int x = 0;
                    //int y = 0;
                    NumbInput(n, ref x, ref y);
                    Console.WriteLine("Результат: " + LogicOperation(n, x, y));
                }
                break;
            case 4:
                {
                    //int x = 0;
                    //int y = 0;
                    NumbInput(n,ref x,ref y);
                    Console.WriteLine("Результат: " + LogicOperation(n, x));
                }
                break;
            case 5: program = false;Environment.Exit(0); break;
            default: Console.WriteLine("Некорректный ввод, введите число от 1 до 5, нажмите юбую клавишу, чтобы продолжить"); break;
        }
    }
    Console.ReadKey();
}
while (program);
void NumbInput(int n,ref int x,ref int y)
{
    if(n==1)
    {
        Console.Write("Введите первый множитель:");
        while (!int.TryParse(Console.ReadLine(), out x)) Console.WriteLine("Неверный ввод, введите целое число");
        Console.Write("Введите второй множитель:");
        while (!int.TryParse(Console.ReadLine(), out y)) Console.WriteLine("Неверный ввод, введите целое число");
    }
    else if (n==2)
    {
        Console.Write("Введите первое слагаемое:");
        while (!int.TryParse(Console.ReadLine(), out x)) Console.WriteLine("Неверный ввод, введите целое число");
        Console.Write("Введите второе слагаемое:");
        while (!int.TryParse(Console.ReadLine(), out y)) Console.WriteLine("Неверный ввод, введите целое число");
    }
    else if (n==3)
    {
        Console.Write("Введите число:");
        while (!int.TryParse(Console.ReadLine(), out x)) Console.WriteLine("Неверный ввод, введите целое число");
        Console.Write("Введите ключ шифрования:");
        while (!int.TryParse(Console.ReadLine(), out y)) Console.WriteLine("Неверный ввод, введите целое число");
    }
    else if (n==4)
    {
        Console.Write("Введите число:");
        while (!int.TryParse(Console.ReadLine(), out x)) Console.WriteLine("Неверный ввод, введите целое число");
    }
}
