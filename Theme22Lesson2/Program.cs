// Тема 22. Урок 2.

try
{
    Console.Write("Введите числа через пробел: ");
    string nums = Console.ReadLine();
    string[] splitNums = nums.Split(" ");
    int sum = 0;
    foreach (string num in splitNums)
    {
      sum += Convert.ToInt32(num);
    }
    Console.WriteLine("Сумма введенных чисел: " + sum);
}
catch (FormatException e)
{
    Console.WriteLine(e.Message);
}