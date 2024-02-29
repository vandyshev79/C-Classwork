// Считать с консоли строку, состоящую из
// цифр и латинских букв.

// Сформировать новую строку, состоящую из
// букв исходной строки.

// 123passw0rd
// {1 2 3 p a s s w 0 r d}

// Этапы решения
// 1. Ввод строки
// 2. Проход по элементам строки
// 3. Проверка элемента: является ли
// он буквой?
// 4. Дописать подходящий элемент к
// новой строке

string GetLetters(string s)
{
    string letters = "";
    foreach (char e in s)
    {
        if (char.IsAsciiLetter(e) == true)
            letters = letters + e;
    }
    return letters;

}

string str = Console.ReadLine();
string result = GetLetters(str);
Console.WriteLine(result);