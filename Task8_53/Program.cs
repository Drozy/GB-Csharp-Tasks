// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = FillMatrixRnd(m, n);
PrintMatrix(arr);
ReplaceRows(arr);
PrintMatrix(arr);


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

// Замена местами первую и последнюю строку массива
void ReplaceRows(int[,] matrix)
{
    int temp;
    int rows = matrix.GetLength(0) - 1;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        temp = matrix[0, j];
        matrix[0, j] = matrix[rows, j];
        matrix[rows, j] = temp;
    }
}