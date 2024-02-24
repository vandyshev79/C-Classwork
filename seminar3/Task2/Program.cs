// Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10]. 
// Замените отрицательные элементы на положительные, а положительные на отрицательные.

// Пример

// [1 -5 6]

// => [-1 5 -6]

int[] mas = new int [10];
for (int i = 0; i < mas.Length; i++)
{
    Console.WriteLine($"Введите значения {i} элемента массива mas: ");
    mas [i] = Convert.ToInt32(Console.ReadLine());
}
foreach (var item in mas)
{
    Console.Write($"{item} ");
}
Console.WriteLine();
for (int i = 0; i < mas.Length; i++)
{
    mas [i] *= (-1);
}
foreach (var item in mas)
{
    Console.Write($"{item} ");
}