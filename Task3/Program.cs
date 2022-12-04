// Напишите программу, которая принимает на вход число и выдает количество цифр в числе.

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int size = 1;
while (n / 10 != 0)
{
  n /= 10;
  size ++;
}

Console.WriteLine(size);