// Напишите программу, которая принимает на вход трёхзначное число и
// удаляет вторую цифру этого числа. Метод строки(string).

Console.WriteLine("Введите число ");
int num = new Random().Next(100, 1000);
Console.WriteLine(num);
string num_st = Convert.ToString(num);

if(num_st.Length == 3)
{
int num_1 = Convert.ToInt32(Convert.ToString(num_st[0]));
int num_3 = Convert.ToInt32(Convert.ToString(num_st[2]));

Console.WriteLine(num_1 * 10 + num_3);
}
else
{
Console.WriteLine("Введено не трехзначное число");
}