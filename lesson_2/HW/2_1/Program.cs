//Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

string Number(int num)
{
    if (num < 1000 && num > 100)
        return $"{num / 10 % 10}";
    return "The second digit";
}

Console.WriteLine(Number(int.Parse(Console.ReadLine()!)));
