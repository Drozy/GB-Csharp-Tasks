// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// для вещественных чисел типы float, double или decimal
// выбрал double для простой генерации значений

double[] arrRand(int size, int minValue, int maxValue)      // функция заполнения массива случайными числами с плавающей запятой
{
    double[] a = new double[size];
    for (int i = 0; i < size; i++)
    {
        a[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;   // NextDouble выдает значения от 0 до 1
    }
    return a;
}

void arrPrint(double[] a)      // функция вывода массива строкой
{
    Console.WriteLine($"[{String.Join(" ", a)}]");
}

double arrMin(double[] a)     // минимальный элемент
{
    double min = a[0];
    for (int i = 1; i < a.Length; i++)
    {
        if (min > a[i])
            min = a[i];
    }
    return min;
}

double arrMax(double[] a)     // максимальный элемент
{
    double max = a[0];
    for (int i = 1; i < a.Length; i++)
    {
        if (max < a[i])
            max = a[i];
    }
    return max;
}

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] arr = arrRand(size, -20, 20);         // создаём массив с заданными параметрами
arrPrint(arr);                       // выводим заполненный массив
Console.WriteLine($"Разница между {arrMax(arr)} и {arrMin(arr)} равна {arrMax(arr) - arrMin(arr)}");
