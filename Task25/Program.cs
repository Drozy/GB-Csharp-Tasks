// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double pow(int a, int b)
{
    double result = a;
    for (int i=1; i<b; i++)
    {
        result = result * a;
    }
    return result;
}

Console.Clear();
Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{a} в степени {b} равно {pow(a,b)}");
