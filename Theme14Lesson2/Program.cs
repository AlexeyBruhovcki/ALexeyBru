// тема 14. Урок 2
//Задача 1
//Random rnd= new Random();
//int temperature = 0;
//for (int i = 1; i < ++i; i++)
//{
//    temperature = rnd.Next(1, 101);
//    Console.Write($"Текущая температура: {temperature}\n");
//    if (temperature > 90)
//    {
//        Console.WriteLine("Остановка устройства");
//        break;
//    }
//}

//Задача 2
using System;

class Program
{
    static void Main()
    {
        Console.Write("Укажите количество квадратов: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        Console.Write("Укажите сторону квадрата: ");
        int weigth = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < quantity; i++)//цикл от i=0 до i<(количество квадратов). 
        {
            for (int j = 0; j < weigth; j++)// выводит "* " (длина стороны квадрата - 1)раз
            {
                Console.Write("*");//вывод *
                Console.Write(" ");//вывод пробела
            }
            Console.WriteLine();
            for (int k = 0; k < weigth - 2; k++)//цикл от k=0 до k<(длина стороны квадарата - 2).
            {
                Console.Write("*");//выводит "*" один раз
                for (int l = 0; l < weigth + weigth - 2; l++)//цикл от l = 0 до l<(х2длина стороны квадарата -2).Выводит пробел l раз.
                {
                    Console.Write(" ");//вывод пробела
                }
                Console.Write("*");//выводит "*" один раз
                Console.WriteLine();
            }
            for (int m = 0; m < weigth; m++)//повторяет цикл j
            {
                Console.Write("*");//вывод *
                Console.Write(" ");//вывод пробела
            }

            Console.WriteLine();
        }
    }
}
//Цикл j выводит на экран "* " столько раз, сколько введено в переменной weigth
//Далее начинается цикл k, который повторяется weigth - 2 раз, т.е. мы получаем
//weigth - 2 строк с результатом цикла l, перед и после которого ставятся *.
//Резульататом же цикла l является вывод в строку "пробела"  weigth + weigth - 2 раз.
//Затем начинается цикл m, который повторяет цыкл j.
//Все это происходит в цикле i i раз.