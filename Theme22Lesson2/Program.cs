// Тема 22. Урок 2.
try
{
    Console.Write("Введите числа через пробел: ");
    string nums = Console.ReadLine();
    string[] splitNums = nums.Split(" ");
    int sum = 0;
    foreach(string num in splitNums)
    {
        for(int i = 0; i < num.Length; i++)
        {
            if (!char.IsDigit(num[i]))
            {
                throw new FormatException("Введене строка.Требуется ввести число.");

            }
            if (char.IsDigit(num[i]))
            {
                sum += Convert.ToInt32(num);
            }
        }
        
    }
    Console.WriteLine("Сумма введенных чисел: "+sum);
}
catch(FormatException e)
{
    Console.WriteLine(e.Message);
}

