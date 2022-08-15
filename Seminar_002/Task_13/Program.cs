// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5 / 78 -> третьей цифры нет / 32679 -> 6

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 99)
{
    int indexN = 2; //index of third number
    int i = n.ToString()[indexN] - '0';
    Console.WriteLine($"Третья цифра: {i}");
}
else
{
    Console.WriteLine("Тетьей цифры нет");
}




