
for(int i = 0; i < 12; i++)
{
    string? month = Enum.GetName(typeof (Months),i);
    Console.WriteLine($"Выбран месяц: {month}, порядковый номер {i+1}");
}

enum Months { January,February,March,April,May,June,July,August,Septemper,October,November,December}
