
/*
Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8
*/

void SumNum(int M, int N);

int M = int.Parse(Console.ReadLine()!);
int N = int.Parse(Console.ReadLine()!);
int sum_all = 0;

{
if (N < M)return;

for(int i = M; i <= N; i++)
sum_all += i;

return sum_all;

{
    Console.WriteLine($"{sum_all} ");
}
}
