// Тема 16. Урок 1.
//Задание 1.
//Random random = new Random();
//double[,] mas = new double[3, 3];
//for(int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j< mas.GetLength(1); j++)
//    {
//        mas[i, j] = Math.Round(random.NextDouble() * 20, 2);
//        Console.Write(mas[i, j]+" ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//Console.Write("Выберите число для замены: ");
//double num = double.Parse(Console.ReadLine());
//Console.Write("Число, которым хотите его заменить: ");
//double numReplace = double.Parse(Console.ReadLine());
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        if (mas[i, j] == num)
//        {
//            mas[i, j] = numReplace;
//        }
//    }
//}
//Console.WriteLine();
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {

//        Console.Write(mas[i, j]+" ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//Задание 2.
char[,] mas =
{
    {'т','и'},
    {'а','с'},
    {'в','м'},
    {'у','к'},
    {'б','н'},
};
Console.Write($"{mas[0, 0]}{mas[1, 0]}{mas[3, 1]}{mas[1, 1]}{mas[0,1]}");


