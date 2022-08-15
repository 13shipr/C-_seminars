Console.WriteLine("Укажите номер дня недели");
double n = Convert.ToInt32(Console.ReadLine());
if (n >= 6 && n <=7)
{
    Console.WriteLine("Выходной");
}
else if (n >= 1 && n <= 5)
{
    Console.WriteLine("Будний день");
}
else if (n >= 8)
{
    Console.WriteLine("Необходимо указать число в диапазоне от 1 до 7");
}