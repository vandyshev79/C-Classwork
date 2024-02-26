// Задайте массив из N случайных целых чисел (N вводится с клавиатуры).

// Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7.

// Пример

// [1 5 11 21 81 4 0 91 2 3]

// => 2

Console.Clear();

int[] Random_mas(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = Convert.ToInt32(new Random().Next(21, 1000));
    }
    return mas;
}
void Print_mas(int[] col)
{
    foreach (var item in col)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

int num_count(int[] mas_2)
{
    int n = 0;
    foreach (var i in mas_2)
    {
        if ((i % 10 == 1) && (i % 7 == 0))
        {
            n++;
        }
    }
    return n;
}


Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] mas = Random_mas(new int[n]);
Print_mas(mas);
Console.WriteLine();
Console.WriteLine($"{num_count(mas)} совпадения(ий). Это число ");


// for (int i = 0; i < 10; i++)
// {
//     if (i == 5)
//     {
//         continue;                                               
//     }
//     if (i == 7)
//     {
//         break;
//     }
//     Console.WriteLine(i);
// }