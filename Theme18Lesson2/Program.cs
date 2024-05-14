// Тема 18. Урок 2.
// Задача 1
//Console.Write("Введите целые числа чере запятую: ");
//string strNumbers=Console.ReadLine();
//string[] masNumbers = strNumbers.Split(',');
//int sum = 0;
//foreach (string n in masNumbers)
//{
//    bool isNumber = true;
//    for(int i = 0; i < n.Length; i++)
//    {
//        if (!char.IsDigit(n[i]))
//        {
//            isNumber = false;
//            break;
//        }
//    }
//    if (isNumber)
//    {
//        sum += Convert.ToInt32(n);
//    }

//}
//Console.Write("Сумма чисел: "+(sum));

// Задача 2
Console.Write("Введите предложение: ");
string sentence = Console.ReadLine();
string[] words = sentence.Split(' ');
int count = 0;
foreach (string word in words)
{
    count++;
}
Console.Write("Количество слов: "+(count));