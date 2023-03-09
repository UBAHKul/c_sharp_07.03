// Напишите программу,которая будет выдавать название дня недели по заданному номеру;


Console.Write("Введите число от 1 до 7: ");
int num = int.Parse(Console.ReadLine()!);
if(num == 1)
{
    Console.Write("понедельник");
}

else if(num == 2)
{
    Console.Write("вторник");
}

else if(num == 3)
{
    Console.Write("среда");
}

else if(num == 4)
{
    Console.Write("четверг");
}

else if(num == 5)
{
    Console.Write("пятница");
}

else if(num == 6)
{
    Console.Write("суббота");
}

else if(num == 7)
{
    Console.Write("воскресенье");
}

else
{
    Console.WriteLine("неизвестное число");
}
