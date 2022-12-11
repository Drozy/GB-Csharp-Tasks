// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] Matrix = FillMatrixRnd(m, n);
PrintMatrix(Matrix);
PrintMatrix(PowEvenElements(Matrix));


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

// Возведение элементов массива с четными индексами в степень 2
int[,] PowEvenElements(int[,] matrix)
{
    int[,] newMatrix = matrix;
    for (int i = 0; i < newMatrix.GetLength(0); i+=2)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j+=2)
        {
            newMatrix[i, j] = newMatrix[i, j] * newMatrix[i, j];
        }
    }
    return newMatrix;
}
