// Максимальное из трех чисел. Hапишите метод, 
// который принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
int max = 0;

if(firstNumber > max)
{
    max = firstNumber;
}
if(secondNumber > max)
{
    max = secondNumber;
}
if(thirdNumber > max)
{
    max = thirdNumber;
}

Console.WriteLine("max = " + max);   

// int FindMax = 0;
// if(a > FindMax)              Решение для метода main класса Answer
// {
//     FindMax = a;
// }
// if(b > FindMax)
// {
//     FindMax = b;
// }
// if(c > FindMax)
// {
//     FindMax = c;
// }
// return FindMax;