// Напишите программу, которая на вход принимает два числа и 
// выдает, какое число больше, а какое меньше.
// a = 5; b = 7 -> max = 7
// a =2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3
string num1 = Console.ReadLine()!;
string num2 = Console.ReadLine()!;

int n1 = int.Parse(num1);
int n2 = int.Parse(num2);

if (n1 > n2)
{
    Console.Write("num1 - большее num2 - меньшее");
}
else if (n1 == n2)
{
    Console.Write("num1 и num2 равные");
}
else
{
    Console.Write("num1 - меньшее num2 - большее");
}
