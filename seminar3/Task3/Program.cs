// Найдите произведения пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новый массив.

// Пример

// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

Console.WriteLine("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int[] array2 = new int[n / 2];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент {i + 1} массива из {array.Length}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
foreach (int e in array)
{
    Console.Write($"{e} ");
}
Console.WriteLine("");
for (int i = 0; i < array.Length / 2; i++)
{
    array2[i] = array[i] * array[array.Length - i - 1];
    Console.Write($"{array2[i]} ");
}