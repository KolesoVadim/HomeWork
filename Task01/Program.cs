﻿// По двум заданным числам проверять является ли первое квадратом второго.
Console.Write("Введите первое число: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int second = int.Parse(Console.ReadLine());
if(first * first == second)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}