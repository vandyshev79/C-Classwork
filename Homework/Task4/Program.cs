// Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num < 10)
// {
//     Console.WriteLine(num);
// }
// else
// {
//     while (num > 0)
//     {
//         int currentDigit = num % 10;
//         num /= 10;
//         if (num > 0)
//         {
//         Console.Write(currentDigit + ",");
//         }
//         else
//         {
//         Console.WriteLine(currentDigit);
//         }
// }
// }
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int len_n = Convert.ToInt32(Convert.ToString(n).Length);

while (len_n > 0) 
{    
    int z = n / Convert.ToInt32((Math.Pow(10,len_n - 1))) % 10;
    if (len_n > 0)
    {
         Console.Write(z + ",");    
    }
    else Console.Write(z);
    // {
    //     Console.Write(z);   
    // }
    len_n--;
}
