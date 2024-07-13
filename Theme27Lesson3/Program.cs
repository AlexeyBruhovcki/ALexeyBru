

using Theme27Lesson3;
Numbers numbers = new Numbers();
double[] mas = new double[10];
Random r = new Random();
for(int i = 0; i < mas.Length; i++)
{
    mas[i] = r.NextDouble()*10;
    Console.Write($"{mas[i]:F2} ");
}
Console.WriteLine();
Console.WriteLine(numbers.IsPrime(4));
Console.WriteLine(numbers.IsOdd(2));
Console.WriteLine(numbers.IsEven(3));
Console.WriteLine($"{numbers.CalculateAverage(mas):F2}");

