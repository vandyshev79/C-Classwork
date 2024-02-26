// Заполните массив на  N (вводится с консоли, не более 8) случайных целых чисел от 0 до 9. 

// Сформируйте целое число, которое будет состоять из цифр из массива. 
// Старший разряд числа находится на 0-м индексе, младший – на последнем. 

// Пример

// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

int [] ArrayInput (int n)
{
    Console.WriteLine("Введите число от 1 до 9: ");
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray (int [] a)
{
    foreach (var item in a)
    {
        Console.Write($"{item} ");
    }
}

double ArrayToNumber (int [] a)
{
    double s = 0;
    for (int i = 0; i < a.Length; i++)
    {
        double p = Math.Pow(10,a.Length-i-1);
        s = s + a[i]*p;
    }
    return s;
}

Console.WriteLine("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = ArrayInput(n);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(ArrayToNumber(array));