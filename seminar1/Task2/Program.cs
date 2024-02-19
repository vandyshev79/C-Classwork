// Напишите программу, которая на вход принимает целое число N, а на выходе 
// показывает все ЦЕЛЫЕ числа в промежутке от -N до N.

Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 < 0)
{
    number1 = - number1;
}
int number2 = - number1;
while (number2 <= number1)
{
    Console.Write($"{number2} ");
    number2++;  
}
// number2 = number2 + 1; 
    //number--; number = number - 1;
    // number += 10; number = number + 10;