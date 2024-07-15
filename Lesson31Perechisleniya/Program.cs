
dayOfWeek day = dayOfWeek.Monday;
Console.WriteLine( NextDay(dayOfWeek.Monday));
dayOfWeek NextDay(dayOfWeek day)
{
    return (day < dayOfWeek.Sunday) ? ++day : dayOfWeek.Monday;
}

Console.Write("Введите число т 1 до 5: ");
int n;
int.TryParse(Console.ReadLine()!, out n);
if (n > 0 && n < 6)
{
    CommodityType commodity = (CommodityType)Enum.GetValues(typeof(CommodityType)).GetValue(n - 1)!;
    TransportType transport = TransportType.Semitrailer;
    switch (commodity)
    {
        case CommodityType.FrozenFood:transport=TransportType.Refregirator;break;
            case CommodityType.Food:transport=TransportType.Semitrailer;break;
            case CommodityType.DomesticChemistry:transport=TransportType.Coupling;break;
            case CommodityType.Buildingmaterials:transport=TransportType.OpenSideTruck;break;
        case CommodityType.Petrol:transport = TransportType.FuleTrack;break;
    }
    Console.WriteLine($"Для товара - {commodity} необходим транспорт {transport}");
}
else
{

    Console.WriteLine("Ошибка ввода");
}



//CompareTo - сравнивает текущий экземпляр с звданным объектом.
//<0 если значение текущего экземрляра меньше заданного
//0, если равно
//>0 если значение больше

//GetName выводит имя константы в указанном перечислении.

//GetNames массив имен всех констант.
//GetValues массив значений константв указанном перечислении
//isDefined возвращает призак аличия костанты с указанным значеием в заданном перечислении.
//Parse преобразует сртоковое значение



Console.Write("Введите название планеты на нглийском: ");
string name = Console.ReadLine()!;
if(!Enum.IsDefined(typeof(DistanceSun), name))
{
    Console.WriteLine($"Значения {name} нет в перечислении");
}
foreach(DistanceSun item in Enum.GetValues(typeof(DistanceSun)))
{
    Console.WriteLine("{0,-10} {1,-10} {2,-10}",Enum.Format(typeof(DistanceSun),item,"G"),
        Enum.Format(typeof(DistanceSun),item,"D"),
        Enum.Format(typeof(DistanceSun),item,"X"));
}
foreach(string str in Enum.GetNames(typeof(DistanceSun)))
{
    Console.WriteLine(str);
}
enum enumName { elem1, elem2, elem3, elem4 }
enum dayOfWeek { Monday,Tuseday,Wednesday,Thursday,Friday,Saturday,Sunday}
enum Discount { Default,Incentive=2,patron=5,VIP=15}
enum CommodityType { FrozenFood,Food,DomesticChemistry,Buildingmaterials,Petrol}
enum TransportType { Semitrailer,Coupling,Refregirator,OpenSideTruck,FuleTrack}
enum DistanceSun: ulong { Sun=0,Mercury=57900000,Venus=108200000,Earth=149600000,
    Mars=227900000,Jupiter=778300000,Saturn=14270000000,Uran=2870000000,Neptune=4496000000,Pluto=594600000}


