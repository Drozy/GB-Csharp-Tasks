// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Будем задавать квадратные матрицы, чтобы не проверять их на совместимость/согласованность.
const int size = 3; // размер матриц
int[,] arr1 = CreateMatrix();
int[,] arr2 = CreateMatrix();
int[,] mult = MatrixMultiplication(arr1, arr2);

Console.WriteLine("\nМатрица A");
PrintMatrix(arr1);
Console.WriteLine("Матрица B");
PrintMatrix(arr2);
Console.WriteLine("Произведение матриц АB");
PrintMatrix(mult);

// Заполнение массива случайными числами
int[,] CreateMatrix()
{
    int[,] matrix = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

// Вывод матрицы
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

// Произведение матриц AB состоит из всех возможных комбинаций скалярных произведений вектор-строк матрицы A и вектор-столбцов матрицы B.
int[,] MatrixMultiplication(int[,] a, int[,] b)
{
    int[,] ab = new int[a.GetLength(0), b.GetLength(1)];    // размер не только для любых исходных матриц
    for (int i = 0; i < ab.GetLength(0); i++)
    {
        for (int j = 0; j < ab.GetLength(1); j++)
        {
            ab[i, j] = 0;
            for (int k = 0; k < a.GetLength(1); k++)
            {
                ab[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return ab;
}
