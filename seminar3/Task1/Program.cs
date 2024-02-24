//  Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. 
//  Программа должна выдать ответ: Да/Нет.

// Примеры

// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[n];
//Console.WriteLine(mas);

//while
int ind = 0;
while (ind < mas.Length)
{
Console.Write($"{mas[ind]} ");
ind++;
}
Console.WriteLine();

//for
for (int i = 0; i < mas.Length; i++)
{
Console.Write($"{mas[i]} ");
}
Console.WriteLine();

//foreach
foreach (var item in mas)
{
Console.Write($"{item} ");
}
Console.WriteLine();

//Печать массива
void Print_mas(int[] col)
{
foreach (var item in col)
{
Console.Write($"{item} ");
}
Console.WriteLine();
}

Print_mas(mas);

// Случайные числа
int[] Random_mas(int[] col)
{
for (int i = 0; i < col.Length; i++)
{
col[i] = new Random().Next(1,10);
}
return col;
}

int[] new_mas = Random_mas(mas);
Print_mas(new_mas);

int m = Convert.ToInt32(Console.ReadLine());

int coun = 0;

for (int i = 0; i < new_mas.Length; i++)
{
if(new_mas[i] == m) coun++;
}

if (coun == 0)
{
Console.WriteLine($"Нет");
}
else
{
Console.WriteLine($"Да");
}


int[] Read_mas(int[] col)
{
for (int i = 0; i < col.Length; i++)
{
Console.Write($"Введите элемент массива {i + 1} из {col.Length}: ");
col[i] = Convert.ToInt32(Console.ReadLine());
}
return col;
}

int[] new_mas_2 = Read_mas(mas);
Print_mas(new_mas_2);

coun = 0;
for (int i = 0; i < new_mas_2.Length; i++)
{
if(new_mas_2[i] == m) coun++;
}

if (coun == 0)
{
Console.Write($"Нет");
}
else
{
Console.Write($"Да");
}