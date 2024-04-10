//Тема 11. Урок2.
Console.Write("Введите температуру воздуха: ");
double temp=double.Parse(Console.ReadLine());
if (temp>20) Console.WriteLine("На прогулку можно выпустить слонов, жирафов, львов");
else if (temp<20) Console.WriteLine("На прогулку можно выпустить медведей, волков, пингвинов");
else if (temp==20) Console.WriteLine("На прогулку можно выпустить кенгуру");
else Console.WriteLine("температура не входит в допустимый диапазон");