// Задайте одномерный массив, заполненный случайными
// числами. Найдите сумму элементов, стоящих на нечётных
// позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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

int SumEvenIndex(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i+=2)
         count += arr[i];

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
Console.WriteLine(SumEvenIndex(mass));
