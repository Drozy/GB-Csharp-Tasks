// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintMatrix(CreateMatrixSum(m, n));

// Заполнение массива числами Aₘₙ = m+n
int[,] CreateMatrixSum(int row, int col)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}

// Вывод двумерного массива
void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)   // перебираем строки, GetLenght(0) выдает количество строк
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   // перебираем столбцы, GetLenght(1) выдает количество столбцов
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}