// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Пример:
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
double exp = 1 + Math.Truncate(Math.Log10(num)); // получили количество цифр

if (exp < 3)
    Console.WriteLine("Третьей цифры нет.");
else
{
    double result = Math.Truncate(num % Math.Pow(10, exp-2) / Math.Pow(10, exp-3));
    Console.WriteLine($"Третья цифра введенного числа: {result}");
}

