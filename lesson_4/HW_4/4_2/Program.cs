// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.

// 452 -> 11   ;     sum_all = 0 + % 10

// 82 -> 10  ;           num / 10 % 10 do 

// 9012 -> 12      ;     num > 0


int SumNums(int num)
{
    int sum_all = 0;
    for (; num !=0; num /= 10)
    sum_all += num % 10;
    return sum_all;
}

int num = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNums(num));
