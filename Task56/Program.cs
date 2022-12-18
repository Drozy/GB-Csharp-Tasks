// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = FillMatrixRnd(m, n);
PrintMatrix(arr);
Console.WriteLine($"Строка с наименьшей суммой элементов: {IndexMinRow(arr) + 1}"); // +1 для счета с 1

// Заполнение массива случайными числами
int[,] FillMatrixRnd(int row, int col)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

// Вывод двумерного массива
void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Нахождение индекса строки с наименьшей суммой элементов
int IndexMinRow(int[,] matrix)
{
    int[] sumRows = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)   // сохраняем суммы элементов каждой строки в одномерный массив
    {
        sumRows[i] = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRows[i] += matrix[i, j];
        }
    }
    int min = sumRows[0];
    int minIndex = 0;
    for (int i = 1; i < matrix.GetLength(0); i++)   // находим наименьшую сумму и её индекс
        if (min > sumRows[i])
        {
            min = sumRows[i];
            minIndex = i;
        }
    return minIndex;
}