// Тема 18. Урок 1.
Console.Write("Введите ключевые слова через пробел: ");
string words= Console.ReadLine();
string[] forbiddenWords = words.Split(' ');
string sentence = "";
do
{
    Console.Write("Введите слово для добавления в предложение: ");
    string word = Console.ReadLine();
    for (int i = 0; i < forbiddenWords.Length; i++)
    {

        if (forbiddenWords[i].ToLower() == word.ToLower())
        {
            word = "скрыто";
            break;
        }
    }
    if (word.ToLower() == "конец") break;
    sentence += word+" ";
}
while(true);
Console.Write("Сформированное предложение: "+(sentence));
