﻿// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

// int i = 0;
// int[] a = new int[-4, -3, -2, -1, 0, 1, 2, 3, 4];
// int[] b = new int[-2, -1, 0, 1, 2];

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int i = -1 * number; 

while (i <= number)
{
  Console.Write($"{i} ");
  i++;
}