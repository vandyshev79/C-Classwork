﻿// Назовём число «интересным» если его сумма цифр чётная.
// Создать двумерный массив, состоящий из
// целых чисел. Вывести на экран «интересные»
// элементы массива.



int[,] CreateMatrix(int rowCount, int columsCount)  // Создаём двумерный массив
{
    int[,] matrix = new int[rowCount, columsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

bool ToInteresting(int value)                       // Узнаём, сумма чисел чётная или нет
{
    int sumOfDigits = GetSumOfDigits(value);
    if (sumOfDigits % 2 == 0)
    {
        return true;
    }
    return false;
}

int GetSumOfDigits(int value)                       // Находим сумму чисел
{
    int sum = 0;
    while (value > 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    return sum;
}


void ShowMatrix(int[,] matrix)                      // Создаём вывод
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}



Console.Clear();
int[,] matrix = CreateMatrix(3, 4);
ShowMatrix(matrix);
Console.WriteLine();

foreach (int e in matrix)
{
    if (ToInteresting(e) == true)
    {
        Console.Write($"{e} ");
    }
}