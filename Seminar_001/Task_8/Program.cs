Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (i <= n)
{
    Console.WriteLine($"-> {n = n - n%2}");
    i++;
    n = n-1;
}
