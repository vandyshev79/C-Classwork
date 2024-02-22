// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли первое число кратным второму. Если первое число некратно второму, 
// то программа выводит остаток от деления.

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// if (num2 > num1)
// {
// int temp = num2;
// num2 = num1;
// num1 = temp;
// }

if(num2 == 0)
{
    Console.WriteLine("На ноль делить нельзя!!!");
}
else
{
    int Ostatok = num1 % num2;

    if(Ostatok == 0)
    {
    Console.WriteLine("Да");
    }
    else
    {
    Console.WriteLine($"Нет, Остаток= {Ostatok}");
    }
}

// Блок позволяет перевернуть местами числа. Например, если введём 8 и 16 без блока, то будет не правильно, а с этим блоком поставит правильно 16 8.