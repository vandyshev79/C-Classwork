// Напишите программу, которая принимает
// на вход целое число из отрезка [10, 99] и показывает
// наибольшую цифру числа.

Console.WriteLine("Введите число в диапазоне от 10 до 99: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 10 || num >= 99)
{
    Console.WriteLine($"Неправильное число!!!");
}
else
{
int num1 = num / 10;
int num2 = num % 10;

if (num1 > num2)
{
    Console.WriteLine(num1);
}
else Console.WriteLine(num2);
}
// Console.WriteLine(num1);
// Console.WriteLine(num2);
