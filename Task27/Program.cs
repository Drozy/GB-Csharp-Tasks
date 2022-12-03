// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int sumDigit(int num)
{
    int result = 0;
    num = Math.Abs(num);
    if (num < 10)
        result = num;
    else
    {
        int k = num;
        while(k > 0)
        {
            result = result + k%10;
            k = k/10;
        }
    }
    return result;
}

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {num} равна {sumDigit(num)}");
