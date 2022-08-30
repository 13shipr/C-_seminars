// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.WriteLine("Задайте массив");
Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] matrix = new int[size];
Random rnd = new Random();
for (int i = 0; i < size; i++)
{
    {
        matrix[i] = rnd.Next(1, 999);
        Console.Write('[' + string.Join(", ", matrix[i]) + ']');
    }
}
Console.WriteLine();
int pos = 0;
for (int i = 0; i < size; i++)
    {
        if (matrix[i] >= 10 && matrix[i] <= 99)
        {
            pos++;
        }
    }
    Console.WriteLine($"Количество элементов массива в диапазоне [10, 99]: {pos}");