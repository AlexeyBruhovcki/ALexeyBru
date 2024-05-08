// Тема16. Урок 2.

using System;

char[,] mas =
{
    {' ',' ','X','X',' ',' '},
    {' ','X',' ',' ','X',' '},
    {'X',' ',' ',' ',' ','X'},
    {' ','X','X','X','X',' '},
    {' ',' ','X','X',' ',' '},
    {' ',' ','X','X',' ',' '},
    {' ',' ','X','X',' ',' '},
    {' ',' ','X','X',' ',' '},
    {' ',' ','X','X',' ',' '},
    {' ',' ','X','X',' ',' '},
    {' ','X','X','X','X',' '},

};

do
{
    Console.Clear();
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write(mas[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.Write("Включить лампочку? ");
    string answer = Console.ReadLine();
    switch (answer)
    {
        case ("да"):
            {
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    for (int j = 0; j < mas.GetLength(1); j++)
                    {
                        if (i == 1 && j == 2 || i == 1 && j == 3 || i == 2 && j == 1 || i == 2 && j == 2 ||
                         i == 2 && j == 3 || i == 2 && j == 4) mas[i, j] = 'X';
                    }
                }
            }
            break;
        case ("нет"):
            {
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    for (int j = 0; j < mas.GetLength(1); j++)
                    {
                        if (i == 1 && j == 2 || i == 1 && j == 3 || i == 2 && j == 1 || i == 2 && j == 2 ||
                         i == 2 && j == 3 || i == 2 && j == 4) mas[i, j] = ' ';
                    }
                }
            }
            break;
        default:break;
    }
}
while (true);







