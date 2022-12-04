// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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

int[] arr = arrRand(5);
arrPrint(arr);

for (int i=0; i<arr.Length; i++)
{
    arr[i] = arr[i] * (-1);
}
arrPrint(arr);