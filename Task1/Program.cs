// Найти максимум среди двух чисел

Console.Clear();
int maxNumbers(int n, int m)
{
  if (n > m)
    return n;
  return m;
}
Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат: {maxNumbers(n, m)}");
