﻿// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D
// пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("x1=");
int x1=int.Parse(Console.ReadLine()!);

Console.Write("y1=");
int y1=int.Parse(Console.ReadLine()!);

Console.Write("z1=");
int z1=int.Parse(Console.ReadLine()!);

Console.Write("x2=");
int x2=int.Parse(Console.ReadLine()!);

Console.Write("y2=");
int y2=int.Parse(Console.ReadLine()!);

Console.Write("z2=");
int z2=int.Parse(Console.ReadLine()!);

double Length(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2)),2);
}
Console.Write(Length(x1, x2, y1, y2, z1, z2));
