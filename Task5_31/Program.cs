// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] arrRand(int len)      // функция заполнения массива произвольной длины случайными числами
{
    int[] a = new int[len];
    for (int i=0; i < a.Length; i++)
    {
        a[i] = new Random().Next(-9,10); // диапазон можно менять
    }
    return a;
}

void arrPrint(int[] a)      // функция вывода массива
{
    for (int i=0; i < a.Length; i++)
        Console.Write($"{a[i]} ");
    Console.WriteLine();
}


int[] arr = arrRand(12);
arrPrint(arr);
int sumPlus = 0;
int sumMin = 0;

foreach (var n in arr)
{
    if (n > 0) sumPlus = sumPlus + n;
    else sumMin = sumMin + n;
}

Console.WriteLine($"Сумма положительных элементов равна {sumPlus}");
Console.WriteLine($"Сумма отрицателных элементов равна {sumMin}");
