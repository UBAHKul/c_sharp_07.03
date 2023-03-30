// Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3



int Numbers(int num)
{
    int count = 0;

    for (int i = 1; i <= num; i++)
    {
        Console.Write($"number {i}: ");
        int a = int.Parse(Console.ReadLine()!);
        if (a > 0) count++;
    }
    return count;
}

Console.Write("сколько чисел хотите внести");
int a = int.Parse(Console.ReadLine()!);
int result = Numbers(a);
Console.WriteLine($"Кол-во чисел больше 0: {result}");
