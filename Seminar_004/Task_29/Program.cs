// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array1 = {1, 2, 5, 7, 19};
int[] array2 = {6, 1, 33};

Console.Write("Массив №1: ");
Console.WriteLine('[' + string.Join(", ", array1) + ']');
Console.Write("Массив №2: ");
Console.WriteLine('[' + string.Join(", ", array2) + ']');

