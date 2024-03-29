﻿// Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("b1=");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("k1=");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write("b2=");
double b2 = double.Parse(Console.ReadLine()!);
Console.Write("k2=");
double k2 = double.Parse(Console.ReadLine()!);
IntersectionOfPoint(k1, b1, k2, b2);

void IntersectionOfPoint(double k1, double b1, double k2, double b2)
{
double k = k1 - k2;
    if (k != 0)
    {
        double x = (b2 - b1)/(k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения: ({x}; {y})");

    }
    else if (k1 ==k2 && b1 == b2)
        Console.WriteLine($"Безконечное количество точек пересечения");
    else
        Console.WriteLine($"Нет точек пересечения");
}
