// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)



int[] Random_mas(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = Convert.ToInt32(new Random().Next(100, 1000));
    }
    return mas;
}

// int[] ArrayFlip(int[] mas)
// {

//     for (int i = 0; i < mas.Length / 2; i++)
//     {
//         int temp;
//         temp = mas[i];
//         mas[i] = mas[mas.Length - 1 - i];
//         mas[mas.Length - 1 - i] = temp;

//     }
//     // Console.Write("\nПеревернутый массив: ");
//     foreach (int number in mas)
//     {
//         Console.Write(number + " ");
//     }
//     return mas;

// }


void Print_mas(int[] col)
{
    foreach (var item in col)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}


Console.Clear();
Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] mas = Random_mas(new int[n]);
Print_mas(mas);
Console.WriteLine();
for (int i = 0; i < mas.Length / 2; i++)
    {
        int temp;
        temp = mas[i];
        mas[i] = mas[mas.Length - 1 - i];
        mas[mas.Length - 1 - i] = temp;

    }
    Console.Write("\nПеревернутый массив: ");
    foreach (int number in mas)
    {
        Console.Write(number + " ");
    }
    Console.WriteLine();


// Console.WriteLine($"{ArrayFlip(mas)} ");