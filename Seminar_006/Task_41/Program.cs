// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Задайте массив");
Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите {i + 1} элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write($"Массив из {size} элементов: " + '[' + string.Join(", ", array) + ']');
Console.WriteLine();
int sum = 0;
for (int i = 0; i < size; i++)
{
    if (array[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine($"Чисел > 0 в масиве: {sum}");


