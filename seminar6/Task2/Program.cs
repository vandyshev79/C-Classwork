//На основе символов строки (тип string) сформировать массив символов (тип char[]). 
//Вывести массив на экран.

char[] MassChar(string st)
{
    char[] Mass_char = new char[st.Length];
    for (int i = 0; i < st.Length; i++)
    {
        Mass_char[i] = st[i];
    }
    return Mass_char;
}

void PrintChar(char[] Mass_char)
{
    foreach (char i in Mass_char)
    {
        Console.Write(i);
    }
}


Console.Clear();    
Console.WriteLine("Введите текст на латинице: ");
string input = Console.ReadLine()!;
char[] mass_char_new = MassChar(input);
Console.WriteLine();
PrintChar(mass_char_new);