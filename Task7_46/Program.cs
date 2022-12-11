// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintMatrix(FillMatrixRnd(m, n));

// Заполнение массива случайными числами от -9 до 9
int[,] FillMatrixRnd(int row, int col)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = new Random().Next(-9, 10);
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