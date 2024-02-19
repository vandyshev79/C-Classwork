// Внутри класса Answer напишите метод CompareNumbers, который на вход принимает два числа и выводит, какое число большее, а какое меньшее.
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());        
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number2 > number1)
{
    Console.WriteLine("{1} большее {0} меньшее", number1, number2);
}
else
{
    Console.WriteLine("{0} большее {1} меньшее", number1, number2);
}