// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

void ConvertToBinary(int num)     // перевод числа в двоичную систему и вывод
{
    string a = String.Empty;
    while (num > 0)
    {
        a = Convert.ToString(num % 2) + a;  // записываем порядок в начало строки
        num = num / 2;
    }
    Console.WriteLine(a);
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

ConvertToBinary(num);