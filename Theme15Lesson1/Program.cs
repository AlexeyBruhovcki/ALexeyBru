//Тема 15.Урок1
string[] words = {"освоении","по плечу","сложный","но если","программирования",
    "многие бросают","остальное будет","освоить их","этап в","на этом этапе","Массивы"};
for (int i = 0; i < words.Length; i++)
{
    Console.WriteLine((i + 1)+ " "+words[i]);
}
Console.WriteLine();
string[] phrase=new string[words.Length];
for (int i = 0; i < phrase.Length; i++)
{
    Console.Write($"Введите номер элемента из списка по по порядку следования в предложении: ");
    int n = int.Parse(Console.ReadLine())-1;
    phrase[i]+=words[n];
}
Console.WriteLine();
Console.WriteLine("Итоговая фраза:");
for (int i = 0; i < phrase.Length; i++)
{
    Console.Write(phrase[i] + " ");
}
Console.WriteLine();
