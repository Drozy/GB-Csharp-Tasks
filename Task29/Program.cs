// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] arrRand(int len)      // функция заполнения массива произвольной длины случайными числами
{
    int[] a = new int[len];
    for (int i=0; i < a.Length; i++)
    {
        a[i] = new Random().Next(0,100); // диапазон можно менять
    }
    return a;
}

int[] arrInput(int len)      // функция заполнения массива вручную
{
    int[] a = new int[len];
    for (int i=0; i < a.Length; i++)
    {
        Console.Write($"Введите {i+1} число: ");
        a[i] = Convert.ToInt32(Console.ReadLine());
    }
    return a;
}

void arrPrint(int[] a)      // функция вывода массива
{
    for (int i=0; i < a.Length; i++)
        Console.Write($"{a[i]} ");
    Console.WriteLine();
}

int len = 8;    // длина массива по условию
int[] arr = new int[len];

arr = arrRand(len);   // заполняем значениями массив заданной длины
// arr = arrInput(len);    // или заполняем массив вручную

arrPrint(arr);
