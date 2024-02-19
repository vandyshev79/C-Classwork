// Проверка на чётность.

Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 % 2 == 0)
{
    Console.WriteLine("Чётное");
}
else
{
    Console.WriteLine("Нечётное");
}