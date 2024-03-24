//Тема 6. Урок 1. Преобразованияя типов и способы.

string num = "28";
byte numByte = byte.Parse(num); 
nint numNint = (nint)numByte;
int numInt = (int)numNint;
long numLong = (long)numInt;
double numDouble = (double)numLong;

Console.Write($" byte: {numByte}\n nint: {numNint}\n" +
    $" int: {numInt}\n long: {numLong}\n double: {numDouble}");





