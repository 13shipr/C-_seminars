// Задача 38: Задайте с клавиатуры массив вещественных (double) чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// #1

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите {i + 1} элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write($"Массив из {size} элементов: " + '[' + string.Join(", ", array) + ']');
int max = 0;
int min = 0;
for (int i = 0; i < size; i++)
{
    if (max < array[i])
    {
        max = array[i];
    }
    if (array[i] < array[min])
    {
        min = i;
    }
}
Console.WriteLine();
Console.WriteLine($"Решение: {max} - {array[min]} = {max - array[min]}");


// #2

Console.WriteLine("Массив: ");
double [] array = {3, 7, 22, 2, 78};
Console.Write($"Массив из {array.Length} элементов: " + '[' + string.Join(", ", array) + ']');
double max = 0;
double min = 0;
for (int i = 0; i < array.Length; i++)
{
    if (max < array[i])
    {
        max = array[i];
    }
    if (array[i] < array[min])
    {
        min = i;
    }
}
Console.WriteLine();
Console.WriteLine($"Решение: {max} - {array[min]} = {max - array[min]}");
