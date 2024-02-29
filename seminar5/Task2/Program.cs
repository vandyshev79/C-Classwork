// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.


int[,] InputMatrixArrayFromKeyboard(int n, int m)
{
    int[,] arr = new int[n, m];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.WriteLine($"Введите {j} элемент для строки {i}: ");
            arr[i, j] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int SummarizeElementsMatrixArray(int[,] arr)
{
    int s = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j)
            {
                s = s + arr[i, j];
            }
        }
    }
    return s;
}

Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = InputMatrixArrayFromKeyboard(n, m);
PrintArray(array);
int s = SummarizeElementsMatrixArray(array);
Console.WriteLine($"Сумма элементов находящихся на главной диагонали равна {s}");