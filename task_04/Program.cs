﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Input first num: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second num: ");
int second = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second num: ");
int third = Convert.ToInt32(Console.ReadLine());
int max = first;

if (max < first) max = first;
if (max < second) max = second;
if (max < third) max = third;

Console.WriteLine($"max numer is: {max}");