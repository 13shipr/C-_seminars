Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
int Factorial (int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n-1);
}
Console.WriteLine($"Решение: {Factorial(N)}");