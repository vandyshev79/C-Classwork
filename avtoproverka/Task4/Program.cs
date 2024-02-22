// Вывести четные числа

Console.Write("Введите число больше нуля: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0)
{
    Console.WriteLine("Число неправильное");    
}
int number1 = number % 2;
while (number1 <= number)
{
    if (number1 % 2 == 0)
    {
        Console.Write($"{number1} ");
    }
    number1++;  
}