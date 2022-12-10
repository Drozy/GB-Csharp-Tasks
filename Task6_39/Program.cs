// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] arrRand(int size, int minValue, int maxValue)      // функция заполнения массива случайными числами
{
    int[] a = new int[size];
    for (int i=0; i < size; i++)
    {
        a[i] = new Random().Next(minValue, maxValue+1); 
    }
    return a;
}

void arrPrint(int[] a)      // функция вывода массива строкой
{
    Console.WriteLine($"[{String.Join(", ", a)}]");
}

int[] arrReverse(int[] a)   // переворачиваем массив
{
    int temp;
    for (int i = 0; i < a.Length/2; i++)
    {
        temp = a[i];
        a[i] = a[a.Length - 1 - i];   // последний индекс меньше длины на 1
        a[a.Length - 1 - i] = temp;
    }
    return a;
}

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = arrRand(size, 1, 10);  // создаём массив с заданными параметрами
arrPrint(arr);
arrReverse(arr);
arrPrint(arr);

