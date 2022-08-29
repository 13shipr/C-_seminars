// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.WriteLine("Задайте массив");
Console.Write("Введите номер строки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[5, 5];
Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = rnd.Next(-10, 10);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
if (m < matrix.GetLength(0) +1 && n < matrix.GetLength(1) +1)
{
    Console.WriteLine($"В этом массиве такой элемент есть - это число: {matrix[m-1,n-1]} ");
}
else
{
    Console.WriteLine($"Элемента в этом массиве не существует");
}
