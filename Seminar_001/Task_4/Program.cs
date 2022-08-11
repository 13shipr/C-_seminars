Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && c < a)
{ 
    Console.WriteLine($"Максимальное число: {a}");
}

if (b > c && b > a)
{
    Console.WriteLine($"Максимальное число: {b}");
}

if (c > a && c > b)
{
    Console.WriteLine($"Максимальное число: {c}");
}