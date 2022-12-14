// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumDigits(int a)
{
    if (a == 0) return 0;
    else return a % 10 + SumDigits(a / 10);
}

Console.WriteLine($"Сумма цифр равна {SumDigits(num)}");
