/*
 
Задайте двумерный массив. Напишите программу,  
которая поменяет местами первую и последнюю строку массива.

Начальные условия:

int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
}; 
Выводится:

9   10  11  12
5   6   7   8
1   2   3   4

 */



void PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}


int[,] RandomDoubleArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10, 100);
        }
    }
    return array;

}


int[,] SwapFirstLastRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = temp;
    }
    return array;
}



Console.Clear();
Console.Write("Введите размерность строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = RandomDoubleArray(m, n);

PrintArr(array);
Console.WriteLine();

Console.WriteLine(SwapFirstLastRows(array));
