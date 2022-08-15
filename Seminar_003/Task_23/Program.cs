Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i <= n)
{ 
    Console.WriteLine(Math.Pow(i,3)); // or (i * i * 1) whithout Math.Pow
    i++;
}
