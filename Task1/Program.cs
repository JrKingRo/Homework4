﻿/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("Введите число A: ");
int numA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int numB = int.Parse(Console.ReadLine());


for (int i = 1; i <= numB;)
{
    double result = Math.Pow(numA, numB);
    Console.Write(result);
    break;
}

