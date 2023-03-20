// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

void Palindrome(int num)
{
    int num1_2 = num / 1000;
    int num5 = num % 10;
    int num4 = num / 10 % 10;

    if (num1_2 == num5 * 10 + num4)
        Console.WriteLine($"{num} - is a palindrome");
    else
        Console.WriteLine($"{num} - is not a palindrome");
}

Console.WriteLine("Enter a five-digit number");
int val = int.Parse(Console.ReadLine()!);

Palindrome(val);
