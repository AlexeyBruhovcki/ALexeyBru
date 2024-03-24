// Тема 6. Урок 2. Преобразования типов и способы.

double num = double.Parse(Console.ReadLine());
byte numByte = (byte)num;
nint numNint = (nint)num;
int numInt = (int)num;
long numLong = (long)num;

Console.WriteLine(num.ToString() + " " + num.GetType());
Console.WriteLine(numByte.ToString() + " " + numByte.GetType());
Console.WriteLine(numNint.ToString() + " " + numNint.GetType());
Console.WriteLine(numInt.ToString() + " " + numInt.GetType());
Console.WriteLine(numLong.ToString() + " " + numLong.GetType());




