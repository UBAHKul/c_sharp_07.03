<<<<<<< HEAD
﻿// 2. Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

void Print(int[,] arr)
{
int row_size = arr.GetLength(0);
int column_size = arr.GetLength(1);

for (int i = 0; i < row_size; i++)
{
for (int j = 0; j < column_size; j++)
Console.Write($" {arr[i, j],4} ");
Console.WriteLine();
}
Console.WriteLine();

}

int[,] MassNums(int row, int column, int from, int to)
{
int[,] arr = new int[row, column];

for (int i = 0; i < row; i++)
for (int j = 0; j < column; j++)
arr[i, j] = new Random().Next(from, to + 1);

return arr;
}

int[] SumNum(int[,] arr)
{
int row = arr.GetLength(0);
int column = arr.GetLength(1);
int[] all_nums = new int[row];

for (int i = 0; i < row; i++)
{
for (int j = 0; j < column; j++)
{
all_nums[i] += arr[i, j];
}
}
return all_nums;
}

void FindMin(int[] arr)
{
int min_ind = 0;
for (int i = 1; i < arr.Length;i++)
{
    if (arr[i] < arr[min_ind]) min_ind = i;

}
Console.WriteLine($"Sum of elements: {arr[min_ind]}, line: {min_ind + 1}");
}

Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);
=======
﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
>>>>>>> 8_lesson
