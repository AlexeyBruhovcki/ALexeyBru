//Тема11. Урок4.
Console.Write("Введите ваш возраст: ");
int age = int.Parse(Console.ReadLine());
if (age < 18) Console.Write("Вы слишком молоды для участия в выборах\n");
else if (age >= 18 && age <= 35) Console.Write("Вы можете участвовать в выборах в качестве депутата\n");
else if (age >= 36 && age <= 65) Console.Write("Вы можете участвовать в выборах в качестве кандидата в президенты\n");
else Console.Write("Ваш возраст слишком велик для участия в выборах\n");
Console.Write("За кого из кандидатов бы вы голосовали?\n");
Console.Write("Кандитдаты:\nНезнайка\n" +
    "Лунтик\n" +
    "Карлсон\n" +
    "Дядя Фёдор\n");
string name = Console.ReadLine();
if (name.ToLower()=="незнайка") Console.WriteLine("А утебя в животе арбуз вырастет!!!");
else if(name.ToLower()=="лунтик") Console.WriteLine("Я родился");
     else if (name.ToLower() == "карлсон") Console.WriteLine("Спокойствие, только спокойствие");
          else if(name.ToLower() =="дядя фёдор"|| name.ToLower() == "дядя федор") 
          Console.WriteLine("Чтобы продать что-нибудь ненужное, нужно сначала купить что-нибудь ненужное, а у нас денег нет.");