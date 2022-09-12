// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int [] array = {1, 3, 5, 7, 9};
int [] copy = new int [array.Length];
Console.Write($"Массив: " + '[' + string.Join(", ", array) + ']');
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    copy[i] = array[i];
}
Console.Write($"Копия массива: " + '[' + string.Join(", ", copy) + ']');
Console.WriteLine();
