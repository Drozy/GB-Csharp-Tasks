﻿// 7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//	456 -> 6
//	782 -> 2
//	918 -> 8

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result;
result = num % 100; // отсекаем сотни (первую цифру)
result = result % 10; // отсекаем десятки
Console.Write($"Последняя цифра {result}");