// Тема 15. Урок 2
int[] num=new int[10];
Random random = new Random();
for (int i = 0; i < num.Length; i++)
{
    num[i] = random.Next(10, 100);
    Console.Write(num[i] + " ");
}
Console.WriteLine();
int count = 0;
for (int i = 0; i < num.Length; i++)
{
    if (num[i] % 2 == 0) count +=1;
}
Console.WriteLine();
Console.WriteLine("Число четных чисел: "+ count);
