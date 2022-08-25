// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// вообще не понял как и что поэтому в первом случае так вот, а во втором ввод массива руками

// №1

int[] array1 = {1, 2, 5, 7, 19};
int[] array2 = {6, 1, 33};

Console.Write("Массив №1: ");
Console.WriteLine('[' + string.Join(", ", array1) + ']');
Console.Write("Массив №2: ");
Console.WriteLine('[' + string.Join(", ", array2) + ']');
Console.WriteLine('[' + string.Join(", ", array1) + ", " + string.Join(", ", array2) + ']');

// №2

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите {i + 1} элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write($"Массив из {size} элементов: " + '[' + string.Join(", ", array) + ']');
Console.WriteLine();