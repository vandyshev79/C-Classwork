// Напишите программму, которая принимает на вход трёхзначное целое число
// и на выходе показывает сумму первой и последней цифры этого числа.

Console.WriteLine("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a <= 999 && a >=100)
{
    int b = a / 100;
    int c = a % 10;
    int sum = b + c;
    Console.WriteLine(sum);   
}
else
{
    Console.WriteLine("Число не трёхзначное");
}