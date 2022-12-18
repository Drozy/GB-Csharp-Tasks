// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string nums = string.Empty;

// не самый лучший вывод через строковую переменную
void Enumeration(int a)
{
    if (a == 1) nums = "1 " + nums;
    else
    {
        nums = Convert.ToString(a) + " " + nums;
        Enumeration(a - 1);
    }
}
Enumeration(n);
Console.WriteLine(nums);
