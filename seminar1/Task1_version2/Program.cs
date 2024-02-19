// Напишите программу, которая на вход принимает два целых числа и проверяет,
// является ли первое число квадратом второго.

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1 == number2 * number2) 
// {
// Console.WriteLine("Да");
// }
// else Console.WriteLine("Нет");

if (number1 == Math.Pow(number2,2))
{
Console.WriteLine("{1} в квадрате равно {0}", number1, number2);
}
else Console.WriteLine($"{number2} в квадрате НЕ равен {number1}");

// Console.WriteLine("Квадрат числа " + number2 + " равен " + number1);