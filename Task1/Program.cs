﻿/*Напишите программу, которая выводит случайное число из отрезка [10, 99] 
и показывает наибольшую цифру числа.

Например:
78 -> 8
12-> 2
85 -> 8*/

Console.Clear();
int number = new Random().Next(10, 100);
Console.WriteLine (number);
if (number/10 > number%10)
{
    Console.WriteLine(number/10);
}
else
Console.WriteLine(number%10);

// генерирует в заданном диапазоне кооме последнего числа
int num = new Random().Next(10, 100);
Console.WriteLine(num);

// Для сравнения чисел нужно их 
//разделить первое делим второе 

if (num / 10 > num % 10)
{
    Console.WriteLine(num / 10);
}
else
{
    Console.WriteLine(num % 10);
}