﻿// Тема 14. Урок 1
Console.Write("Введите длину пароля: ");
int lenght = int.Parse(Console.ReadLine());
string letters = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
string num = "0123456789";
string passWord = "";
Random random1 = new Random();
Random random2 = new Random();
Random random3 = new Random();
for (int i = 1;i<= lenght;i++)
{
    int n1 = random1.Next(1,3);
    int n2 = random2.Next(52);
    int n3 = random3.Next(10);
    if (n1 == 1)
    {
        passWord += letters[n2];
    }
    if (n1 == 2) 
    {
        passWord += num[n3];
    }
}
Console.WriteLine(passWord);