﻿// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее
Console.WriteLine("Введите первое число:   ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число, отличное от первого:   ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA > numberB)
{
    Console.WriteLine("Первое число " + numberA + " больше чем второе " + numberB);
}
else
{
    Console.WriteLine("Второе число " + numberB + " больше чем первое " + numberA);
}