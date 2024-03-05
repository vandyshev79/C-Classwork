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
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;

}


int[,] FindElementByPosition(int[,] array, int x, int y)
{
    int[,] array2 = new int[x, y];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == x && array[i, j] == y)
            {
                array2[x, y] = array[i, j];
            }
                Console.WriteLine("{array2[x, y}");
        }
    }
    return array2;
}


bool ValidatePosition(int[,] array, int x, int y)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array.GetLength(0) < x)
        {
            Console.WriteLine("Позиция по рядам выходит за пределы массива");
            return false;
        }
        if (array.GetLength(1) < y)
        {
            Console.WriteLine("Позиция по колонкам выходит за пределы массива");
            return false;
        }
    }


}
return true;
}


//void PrintResult(int[,] arrayCoordinates, int x, int y)
//{
//        Console.WriteLine("FindElementByPosition {arrayCoordinates}");
//}



Console.Clear();
Console.Write("Введите размерность строк m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите размерность столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = RandomDoubleArray(m, n);

PrintArr(array);
Console.WriteLine();

Console.Write("Введите координату Х: ");
int x =  Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
var result = ValidatePosition(array, x, y);
FindElementByPosition(array, x, y);