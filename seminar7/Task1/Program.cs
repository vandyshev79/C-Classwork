// Программа принимает на вход число
// и возвращает сумму его цифр. 

//   Рекурсивный метод.




int SumNum(int num)
{
    if (num == 0) return 0;
    int res = num % 10 + SumNum(num / 10);
    return res;
}



Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNum(n));