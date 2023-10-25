﻿// Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая
// покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void Print(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] Nums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to + 1);
    return arr;
}

int Even(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 ==0)
            count += 1;
    }
    return count;
}
Console.Write("Кол-во элементов");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Начало диапозона");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Конец диапозона");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = Nums(num, start, stop);
Print(mass);
Console.WriteLine(Even(mass));
