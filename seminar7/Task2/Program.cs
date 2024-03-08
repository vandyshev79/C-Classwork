// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.


//void PrintNumber(int number)
//{
//    if (number < 1) return;
//    Console.Write($"{number} ");              // Если эту строку переместить на 10 строку, то числа будут выводится от 1 до 5
//    PrintNumber(number - 1);
//}



//Console.WriteLine("Введите число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//PrintNumber(number);


string PrintNumber(int n, int m)
{
    if (n == m)
    {
        return Convert.ToString(n);
    }
    return n + " " + PrintNumber(n + 1, m);
}



Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(PrintNumber(1, number));
