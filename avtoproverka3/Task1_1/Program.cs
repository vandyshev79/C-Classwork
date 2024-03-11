/*
 Напишите программу, которая на вход
 принимает позиции элемента в двумерном массиве, и
 возвращает значение этого элемента или же указание,
 что такого элемента нет."Позиция по рядам выходит за пределы массива"

Пример
4 3 1  (1,2) => 9
2 6 9 

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


int[,] FindElementByPosition(int[,] array, int x, int y)
{
    array[x, y] = array[x - 1, y - 1];
    return array;
}



 bool ValidatePosition(int[,] array, int x, int y)
{
    if (array.GetLength(0) < x || array.GetLength(1) < y)
    {
        return false;
    }
    return true;
}


void PrintResult(int[,] numbers, int x, int y)
{
    if (ValidatePosition(numbers, x, y))
    {
        Console.WriteLine(FindElementByPosition(numbers, x, y));
    }
    else
    {
        Console.Write("Позиция по рядам выходит за пределы массива");
    }
}



Console.Clear();
Console.Write("Введите размерность строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = RandomDoubleArray(m, n);

PrintArr(array);
Console.WriteLine();
Console.Write("Введите координату Х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
bool ValidateResult = ValidatePosition(array, x, y);
int[,] numbers = FindElementByPosition(array, x, y);
PrintResult(numbers, x, y);



//if (x > 0 && y > 0 && x <= array.GetLength(0) && y <= array.GetLength(1))
//{
//    Console.WriteLine(array[x - 1, y - 1]);
//}
//else Console.WriteLine();
//Console.WriteLine();
