// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
int first = 0;
Console.Write("{0} ", first);
int second = 1;
Console.Write("{0} ", second);
int sum = 0;
int i = 0;
while (i < N-2)
{
    sum = first + second;
    Console.Write("{0} ", sum);
    first = second;
    second = sum;
    i++;
}
Console.WriteLine();

