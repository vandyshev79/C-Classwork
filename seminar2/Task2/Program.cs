// Напишите программу, которая принимает на вход трёхзначное число и 
// возводит вторую цифру этого числа в степень, равную третьей цифре.

Console.WriteLine("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num / 10 % 10;
int num2 = num % 10;
Console.WriteLine(Math.Pow(num1,num2));