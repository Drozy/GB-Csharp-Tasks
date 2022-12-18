// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());

// Вывод чисел от N до 1 (можно вывести от 1 до N поменяв строки 14 и 15 местами)
void Enumeration(int a)
{
    if (a == 1) Console.Write($"{a} ");
    else
    {
        Console.Write($"{a} ");
        Enumeration(a - 1);
    }
}

Enumeration(num);
