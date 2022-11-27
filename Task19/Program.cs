// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Сделаем для любого числа
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int exp = Convert.ToInt32(1 + Math.Truncate(Math.Log10(num)));
double[] digit = new double [exp];    // заполним массив цифрами введенного числа
for (int i=0; i<exp; i++)
{
    digit[i] = (Math.Truncate(num / Math.Pow(10, exp-1-i))) % 10;
}

bool poly = false;  // флаг да/нет
int k = digit.Length / 2;
for (int i=0; i<k; i++)     // сравниваем зеркальные цифры нашего числа
{
    if (digit[i] == digit[exp-1-i]) poly = true;
    else poly = false;
}

if (poly) Console.WriteLine("Это полином");
else Console.WriteLine("Это обычное число");