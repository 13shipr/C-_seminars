Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int i = n%100;
int x = n/1000;
int polyndrom = ((i/10) + (i%10*10));
if (x == polyndrom)
    {
        Console.WriteLine("Это палиндром");
    }
else
    {
        Console.WriteLine("Это не палиндром");
    }

