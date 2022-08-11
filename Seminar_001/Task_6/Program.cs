Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int i = n%2;
if (i == 0)
{
    Console.WriteLine($"Число: {n} четное");
}
else
{
    Console.WriteLine($"Число: {n} нечетное");
}