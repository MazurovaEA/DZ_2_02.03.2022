﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трехзначное число => ");
string inputA = Console.ReadLine();
int A = int.Parse(inputA);
Console.WriteLine($"Вторая цифра числа => {A%100/10}");