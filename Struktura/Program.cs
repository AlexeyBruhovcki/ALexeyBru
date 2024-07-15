

Student student = new Student();
Console.Write("Введите ФИО: ");
student.fam = Console.ReadLine()!;
Console.Write("Введите дату рождения: ");
student.birthDate = DateTime.Parse(Console.ReadLine()!);
Console.Write("Введите пол Мужской/Женский: ");
student.gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine()!);
Console.Write("Введите курс: ");
student.kurs = int.Parse(Console.ReadLine()!);

Console.WriteLine("Ваш возраст "+student.GetVozrast());
enum Gender 
{
    Мужской,
    Женский
}

struct Student
{
    public string fam;
    public DateTime birthDate;
    public Gender gender;
    public int kurs;
    public int GetVozrast()
    {
        return Convert.ToInt32((DateTime.Today - birthDate).Days / 365.25);
    }
}
