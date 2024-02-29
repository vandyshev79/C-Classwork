// Задайте двумерный массив из целых чисел. 
// Сформируйте новый одномерный массив, состоящий 
// из средних арифметических значений по строкам двумерного массива.


int[,] Random_mas(int m, int n)
{
  int[,] arr = new int[m,n];
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i,j] = new Random().Next(1, 10);
    }
  }
  return arr;

}

void Print_mas(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write($"{arr[i,j]}\t");
    }
    Console.WriteLine();
  }
}

double[] mean(int[,] arr)
{
  double[] mas_one = new double[arr.GetLength(0)];
  
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    double summ = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      summ += arr[i,j];
    }
    mas_one[i] = summ / arr.GetLength(1);
  }
  return mas_one;
}

void Print_mas_one(double[] mass)
{
  foreach (var item in mass)
  {
    Console.Write($"{item} ");
  }
  Console.WriteLine();
}
 
Console.Clear(); 
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = Random_mas(m,n);
Print_mas(arr);
double[] mas_one = mean(arr);
Print_mas_one(mas_one);