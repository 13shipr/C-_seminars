﻿Console.WriteLine("Введите первое число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число b");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{ 
    Console.WriteLine($"Максимальное число: {a}");
    Console.WriteLine($"Минимальное число: {b}");
}
else
{
    Console.WriteLine($"Максимальное число: {b}");
    Console.WriteLine($"Минимальное число: {a}");
}

