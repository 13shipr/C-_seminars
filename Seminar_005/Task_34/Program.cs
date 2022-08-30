// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Задайте массив");
Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] matrix = new int[size];
Random rnd = new Random();
for (int i = 0; i < size; i++)
{
    {
        matrix[i] = rnd.Next(100, 1000);
        Console.Write('[' + string.Join(", ", matrix[i]) + ']');
    }
}
Console.WriteLine();
int pos = 0;
for (int i = 0; i < size; i++)
    {
        if (matrix[i] % 2 == 0)
        {
            pos++;
        }
    }
    Console.WriteLine($"Количество четных чисел в масиве: {pos}");
