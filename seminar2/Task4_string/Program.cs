// Напишите программу, которая выводит третью слева цифру заданного числа
// или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

string num_str = Convert.ToString(num);
if (num_str.Length < 3)
{
Console.WriteLine("Третьей цифры нет");
}
else Console.WriteLine(num_str[2]);