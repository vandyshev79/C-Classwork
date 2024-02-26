// Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int len_n = Convert.ToInt32(Convert.ToString(n).Length);
//Console.WriteLine($"{len_n} - количество цифр в числе");

while (len_n > 0)
{
    int a = n % 10;
    int currDigit = n / Convert.ToInt32((Math.Pow(10, len_n - 1))) % 10;
    if (len_n > 0)
    {
        Console.Write(currDigit + ",");
    }
    else
        if (currDigit == a)
    {
        Console.Write(currDigit);
    }
    // if (currDigit < a)
    // {
    //     Console.Write(currDigit + ",");
    // }
    // else Console.Write(currDigit);
    len_n--;
}



// int n = 246145869;
// n = n % 10;
// Console.WriteLine(n);