// Тема 24. Урок 1. Рекурсия.

Console.Write("Введите слово или строку: ");
string word = Console.ReadLine()!.ToLower();
string wordChars = string.Concat(word.Where(char.IsLetterOrDigit));
int lastIndex = wordChars.Length - 1;
void IsPalindrom(string wwordChars, int curIndex, int lastIndex)
{
    if (wordChars[curIndex] != wordChars[lastIndex])
    {
        Console.WriteLine("Not a palindrom");
        return;
    }
    else if (curIndex>=lastIndex)
    {
        Console.WriteLine("Is a palindrom");
        return;
    }
    IsPalindrom(wordChars, curIndex + 1, lastIndex - 1);
}
IsPalindrom(wordChars, 0, lastIndex);

