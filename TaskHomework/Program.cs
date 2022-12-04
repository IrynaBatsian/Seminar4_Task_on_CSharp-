//  Напишите программу для нахождения максимального числа ягод, которое может собрать за один заход собирающий модуль, находясь перед некоторым кустом заданной во входном файле грядки. Модуль собирает ягоды с куста, который находится перед ним и с двух ближайших от него.

Console.Clear();

Console.Write("Введите количество кустов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arrayFirst = new int[n]; // Создаем массив с данными
int resultSumma = 0;

for (int i = 0; i < arrayFirst.Length; i ++)
    arrayFirst[i] = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < arrayFirst.Length - 1; i ++)
{
    if (arrayFirst[i - 1] + arrayFirst[i] + arrayFirst[i + 1] > resultSumma)
      resultSumma = (arrayFirst[i - 1] + arrayFirst[i] + arrayFirst[i + 1]);
}
if (arrayFirst[0] + arrayFirst[1] + arrayFirst[n - 1] > resultSumma)
    resultSumma = arrayFirst[0] + arrayFirst[1] + arrayFirst[n - 1];
if (arrayFirst[0] + arrayFirst[n - 1] + arrayFirst[n - 2] > resultSumma) 
    resultSumma = arrayFirst[0] + arrayFirst[n - 1] + arrayFirst[n - 2];

Console.WriteLine(resultSumma);       