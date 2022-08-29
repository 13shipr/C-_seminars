// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Задайте массив");
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
Random rnd = new Random();
int[] sum = new int[n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = rnd.Next(-10, 10);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
for (int j = 0; j < n; j++)
{
    for (int i = 0; i < m; i++)
    {
        sum[j] += matrix[i, j];
    }
}
Console.WriteLine();
Console.WriteLine("Среднее арифметическое: ");
foreach (double elem in sum)
{
    Console.Write(Math.Round(elem / m, 1) + "\t");
}
Console.WriteLine();