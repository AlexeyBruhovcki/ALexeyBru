

using Theme27Lesson3;

double[] mas = new double[10];
Random r = new Random();
for(int i = 0; i < mas.Length; i++)
{
    mas[i] = r.NextDouble()*10;
    Console.Write($"{mas[i]:F2} ");
}
Console.WriteLine();
Console.WriteLine(Numbers.IsPrime(4));
Console.WriteLine(Numbers.IsOdd(2));
Console.WriteLine(Numbers.IsEven(3));
Console.WriteLine($"{Numbers.CalculateAverage(mas):F2}");

