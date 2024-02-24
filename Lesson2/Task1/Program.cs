// int[] arr = new int[5];
// arr[0] = 5;
// arr[1] = 7;
// arr[2] = 5;
// arr[3] = 4;
// arr[4] = 3;
// Console.WriteLine(arr[0]);
// Console.WriteLine(arr[1]);
// Console.WriteLine(arr[2]);
// Console.WriteLine(arr[3]);
// Console.WriteLine(arr[4]);

// int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };

// Создать массив и заполнить его целыми числами от 1 до N (N - произвольное натуральное число).
// Вывести элементы массива на экран

int n = 10;
int[] arr = new int[n];
int i = 0;

while (i < arr.Length)
{
    arr[i] = i + 1;
    Console.Write($"{arr[i]} ");
    i++;
}