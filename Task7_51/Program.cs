// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = FillMatrixRnd(m, n);
PrintMatrix(array);
Console.WriteLine($"Сумма элементов, находящихся на главной диагонали, равна {SumDiagonal(array)}.");


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

// Сумма элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)
int SumDiagonal(int[,] matrix)
{
    int i = 0;
    int sum = 0;
    while (i < matrix.GetLength(0) && i < matrix.GetLength(1))
    {
        sum += matrix[i, i];
        i++;
    }
    return sum;
}