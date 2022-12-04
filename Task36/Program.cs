// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int sumOdd(int[] a)     // сумма элементов, стоящих на нечётных позициях
{
    int sum = 0;
    for (int i=0; i<a.Length; i+=2)
    {
        sum = sum + a[i];
    }
    return sum;
}

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = arrRand(size, -99, 100);  // создаём массив с заданными параметрами
arrPrint(arr);                        // выводим заполненный массив
Console.WriteLine($"Сумму элементов, стоящих на нечётных позициях равна {sumOdd(arr)}");
