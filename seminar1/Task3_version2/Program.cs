// Напишите программму, которая принимает на вход трёхзначное целое число
// и на выходе показывает сумму первой и последней цифры этого числа. МЕТОД СТРОК!!!

Console.WriteLine("Введите трехзначное число: ");
string a = Console.ReadLine()!;
if (a.Length == 3)
{
    Console.WriteLine(Convert.ToInt32(Convert.ToString(a[0])) +
                    Convert.ToInt32(Convert.ToString(a[2])));
}
else
{
    Console.WriteLine("Число не трёхзначное");
}
//  
