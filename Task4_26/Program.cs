// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число: ");
double num = Convert.ToDouble(Console.ReadLine());
double exp = 1 + Math.Truncate(Math.Log10(num)); // получили количество цифр

Console.WriteLine($"Количество цифр {exp}");