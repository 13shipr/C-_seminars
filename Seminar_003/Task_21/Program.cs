﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите число x1: ");
double X1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число у1: ");
double Y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число z1: ");
double Z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число x2: ");
double X2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число у2: ");
double Y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число z2: ");
double Z2 = Convert.ToDouble(Console.ReadLine());
double length = Math.Sqrt(Math.Pow (X2-X1, 2) + Math.Pow(Y2-Y1,2)+ Math.Pow(Z2-Z1,2));
Console.WriteLine(length);