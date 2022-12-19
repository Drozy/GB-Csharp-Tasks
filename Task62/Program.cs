// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// По условию матрица 4х4, работает и с большей размерностью
int n = 4;
int[,] arr = FillMatrixSpiral(n, n);
PrintMatrix(arr);

// Заполнение квадратной матрицы спиралью
int[,] FillMatrixSpiral(int row, int col)
{
    int count = 1;
    int[,] matrix = new int[row, col];
    int i = 0, j = 0;
    while (count <= row * col)
    {
        matrix[i, j] = count;
        count++;
        if (i <= j + 1 && i + j < col - 1)
            j++;
        else if (i < j && i + j >= row - 1)
            i++;
        else if (i >= j && i + j > col - 1)
            j--;
        else
            i--;
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
            Console.Write($"{matrix[i, j]:d2} ");    // вывод двух знаков
        }
        Console.WriteLine();
    }
}
