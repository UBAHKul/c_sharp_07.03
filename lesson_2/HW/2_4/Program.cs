// Напишите программу, которая выводит
// случайное трёхзначное число и удаляет вторую цифру
// этого числа.

string FirstThird(int num)
{
    if (num > 99 && num < 1000)
        return $"{num} -> {num / 100 * 10 + num % 10}";
    return "Two-digit number!";
}

int val = int.Parse(Console.ReadLine()!);
string result = FirstThird(val);
Console.WriteLine(result);
