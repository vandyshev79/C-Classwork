// Проверка строки на палиндром.


bool IsPalindrome(string str)
{
    // Нормализация строки путем удаления не буквенно-цифровыхсимволов и приведения к нижнему регистру
    string normalized = new
    string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
    // Сравнение строки с ее перевернутым вариантом
    return normalized.SequenceEqual(normalized.Reverse());
}




Console.Clear();

//Console.WriteLine("Введите слово: ");
string input = "кабак";
bool isPalindrome = IsPalindrome(input);
Console.WriteLine(isPalindrome ? "Да" : "Нет");