﻿// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


Console.WriteLine("Введите N большее: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите M меньшее: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{Range(n, m)}");

string Range(int n, int m)
{
    if (n == m)
    {
        return m.ToString();
    }
    return Range(n - 1, m) + ", " + n;
}