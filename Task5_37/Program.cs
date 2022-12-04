// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = arrRand(size, 1, 10);  // создаём массив с заданными параметрами
arrPrint(arr);

int k = arr.Length / 2 + arr.Length % 2;    // количество элементов нового массива
int[] prod = new int[k];

for (int i = 0; i < k; i++)
{
    if (i != (arr.Length - 1 - i))  // центральный элемент массива при нечетном количестве элементов не умножаем
        prod[i] = arr[i] * arr[arr.Length-1-i];
    else prod[i] = arr [i];
}
arrPrint(prod);
