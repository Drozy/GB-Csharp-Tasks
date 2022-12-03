// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int sumDigit(int n)
{
    int result = 0;
    n = Math.Abs(n);
    while(n > 0)
    {
        result = result + n%10;
        n = n/10;
    }
    return result;
}

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {num} равна {sumDigit(num)}");
