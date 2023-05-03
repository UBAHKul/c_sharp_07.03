<<<<<<< HEAD
﻿/*Задайте двумерный массив. Напишите программу, которая упорядочит
 по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/
=======
﻿// 1. Задайте двумерный массив. Напишите программу, которая
//    упорядочит по убыванию элементы каждой строки двумерного массива.

>>>>>>> 8_lesson

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
<<<<<<< HEAD
            Console.Write($"{arr[i,j],3}");
        Console.WriteLine();
    }
        Console.WriteLine();
}
=======
            Console.Write($" {arr[i, j],3} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

>>>>>>> 8_lesson
int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
<<<<<<< HEAD
            arr[i,j] = new Random().Next(from, j + 1);
    return arr;

}
=======
            arr[i, j] = new Random().Next(from, to + 1);
    return arr;
}

>>>>>>> 8_lesson
void OrderElMin(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
<<<<<<< HEAD
        for (int j = 0; j< column_size; j++)
        {
            for (int k = 0; k < column_size - j -1; k++)
            if(arr[i,k] < arr[i, k + 1])
            (arr[i,k], arr[i, k + 1]) = (arr[i, k + 1], arr[i,k]);
=======
        for (int j = 0; j < column_size; j++)
        {
            for (int k = 0; k < column_size - j - 1; k++)
                if (arr[i, k] < arr[i, k + 1])
                    (arr[i, k], arr[i, k + 1]) = (arr[i, k + 1], arr[i, k]);
>>>>>>> 8_lesson
        }
    }
}

<<<<<<< HEAD
=======

>>>>>>> 8_lesson
Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);

<<<<<<< HEAD
Print(OrderElMin[i, j]);
=======
Console.Write("Enter the min number of massive ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Enter the max number of massive ");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num, start, stop);
Print(mass);

OrderElMin(mass);
Print(mass);
>>>>>>> 8_lesson
