// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли первое число кратным второму. Если первое число некратно второму, 
// то программа выводит остаток от деления.

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int Ostatok = num1 % num2;

if(Ostatok == 0)
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine($"Нет, Остаток= {Ostatok}");
}