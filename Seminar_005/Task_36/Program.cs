// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.WriteLine("Задайте массив");
Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] matrix = new int[size];
Random rnd = new Random();
Console.WriteLine("Массив: ");
for (int i = 0; i < size; i++)
{
    {
        matrix[i] = rnd.Next(1, 10);
        Console.Write('[' + string.Join(", ", matrix[i]) + ']');
    }
}
Console.WriteLine();
int sum = 0;
for (int i = 0; i < size; i++)
    {
        if (matrix[i] % 2 != 0)
        {
            sum = matrix[i] + sum;
        }
    }
    Console.WriteLine($"Сумма чисел нечетных элементов в масиве: {sum}");
