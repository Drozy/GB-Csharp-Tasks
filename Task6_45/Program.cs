// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] FillArrayRandom(int size, int minValue, int maxValue)      // функция заполнения массива случайными числами
{
    int[] a = new int[size];
    for (int i = 0; i < size; i++)
    {
        a[i] = new Random().Next(minValue, maxValue + 1);
    }
    return a;
}

void PrintArray(int[] a)      // функция вывода массива строкой
{
    Console.WriteLine($"[{String.Join(", ", a)}]");
}

int[] CopyArray(int[] a)    // поэлементное копирование массива
{
    int[] b = new int[a.Length];
    for (int i = 0; i < a.Length; i++)
    {
        b[i] = a[i];
    }
    return b;
}

int[] arr = FillArrayRandom(8, 1, 10);  // создаём массив с заданными параметрами
PrintArray(arr);
int[] arrCopy = CopyArray(arr);
PrintArray(arrCopy);

