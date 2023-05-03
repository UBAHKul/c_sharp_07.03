// 2. Задайте значения M и N. Напишите программу, которая 
//    рекурсивно выведет все четные натуральные числа в промежутке
//    от M до N.


void Even(int M, int N)
{
    if (N < M) return;
 
if (M % 2 == 0)

{
Console.Write($"{M}, ");  
}
Even(M + 1, N);
    
}
int M = int.Parse(Console.ReadLine()!);
int N = int.Parse(Console.ReadLine()!);

Even(M, N);