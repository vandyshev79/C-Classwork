//Задайте массив символов (тип char []). 
//Создайте строку из символов этого массива.

string CharOfString(char[] arr)
{
    string st = "";
    foreach (char i in arr)
    {
        st += i;
    }
    return st;
}


char[] chars = new char[] { 'a', 'b', 'c', 'd' };
Console.WriteLine(CharOfString(chars));