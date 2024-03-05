//Считать строку с консоли, состоящую из латинских букв в нижнем регистре.     
//Выяснить, сколько среди введённых букв гласных.(aoueiAOUEI)


int CountVowels(string st)
{
    int s = 0;
    string vowels = "aoueiAOUEI";
    for (int i = 0; i < st.Length; i++)
    {
        foreach (var j in vowels)
        {
            if (st[i] == j)
            {
                s++;
            }
        }
    }
    return s;
}

bool CheckIfLetter(string st)
{
    for (int i = 0; i < st.Length; i++)
    {
        if (!(char.IsLetter(st[i]) || st[i] == ' '))
        {
            return false;
        }

    }
    return true;
}


Console.Clear();
string st = Console.ReadLine()!;
if (CheckIfLetter(st))
{
    int vowels = CountVowels(st);
    Console.WriteLine(vowels);
}
else
{
    Console.WriteLine("Введен неверный формат");
}