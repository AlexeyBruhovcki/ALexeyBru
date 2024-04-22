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
if (name.ToLower() == "незнайка") Console.WriteLine("А утебя в животе арбуз вырастет!!!");
else if (name.ToLower() == "лунтик") Console.WriteLine("Я родился");
else if (name.ToLower() == "карлсон") Console.WriteLine("Спокойствие, только спокойствие");
else if (name.ToLower() == "дядя фёдор" || name.ToLower() == "дядя федор")
    Console.WriteLine("Чтобы продать что-нибудь ненужное, нужно сначала купить что-нибудь ненужное, а у нас денег нет.");


//Дополнительные задания
//Задание 1
//Random random = new Random();
//int n=random.Next(1,13);
//switch (n)
//{
    //case 1: Console.WriteLine("January"); break;
    //case 2: Console.WriteLine("February"); break;
    //case 3: Console.WriteLine("March"); break;
    //case 4: Console.WriteLine("April"); break;
    //case 5: Console.WriteLine("May"); break;
    //case 6: Console.WriteLine("June"); break;
    //case 7: Console.WriteLine("July"); break;
    //case 8: Console.WriteLine("August"); break;
    //case 9: Console.WriteLine("September"); break;
    //case 10: Console.WriteLine("October"); break;
    //case 11: Console.WriteLine("November"); break;
    //case 12: Console.WriteLine("December"); break;
//}
//Console.WriteLine("Сколько дней в этом месяце?");
//int days=int.Parse(Console.ReadLine());
//if ((n == 1 || n == 5 || n == 7 || n == 3 || n == 8 || n == 10 || n == 12) && days != 31) Console.WriteLine("Поражение, в этом месяце 31 день.");
//else if (n == 2 && (days != 28||days!=29)) Console.WriteLine("Поражение, в этом месяце 28 или 29 дней.");
     //else if ((n == 4 || n == 6 ||n==9|| n == 11) && days != 30) Console.WriteLine("Поражение, в этом месяце 30 дней.");
          //else Console.Write("Победа");

//Задание 2
//Random rnd= new Random();
//int num = rnd.Next(1, 13);
//switch (num)
//{
//    case 1: Console.WriteLine("January"); break;
//    case 2: Console.WriteLine("February"); break;
//    case 3: Console.WriteLine("March"); break;
//    case 4: Console.WriteLine("April"); break;
//    case 5: Console.WriteLine("May"); break;
//    case 6: Console.WriteLine("June"); break;
//    case 7: Console.WriteLine("July"); break;
//    case 8: Console.WriteLine("August"); break;
//    case 9: Console.WriteLine("September"); break;
//    case 10: Console.WriteLine("October"); break;
//    case 11: Console.WriteLine("November"); break;
//    case 12: Console.WriteLine("December"); break;
//}