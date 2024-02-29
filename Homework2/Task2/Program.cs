// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.



int[] Random_mas(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = Convert.ToInt32(new Random().Next(100, 1000));
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

int SumOfDigits(int[] mas)
{
    int count = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if(mas[i] % 2 == 0)
        count++;
    }
    return count;
    
}



Console.Clear();
Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] mas = Random_mas(new int[n]);
Print_mas(mas);
Console.WriteLine();
Console.WriteLine($"Чётных чисел в массиве {SumOfDigits(mas)} ");