// Напишите программу, которая принимает на вход трёхзначное число и
// удаляет вторую цифру этого числа. 

Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
int num = new Random().Next(100, 1000);
Console.WriteLine(num);
if(num <= 999 && num >= 100)
{
int num_1 = num / 100;
int num_3 = num % 10;
// Console.WriteLine(num_1 + " " + num_3);
Console.WriteLine(num_1 * 10 + num_3);
}
else
{
Console.WriteLine("Введено не трехзначное число");
}

// int num = new Random().Next(100, 1000); - Рандомно заставляет придумать компьютер число от 100 до 999
// Console.WriteLine(num_1 * 10 + num_3); - Это математическое решение